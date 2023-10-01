namespace VNet.ProceduralGeneration.Cosmological;

public class SpatialGrid
{
    private readonly SpatialGridCell[,,] _cells;
    private readonly object _lockObj = new();
    private readonly ManualResetEventSlim _signal = new(false);

    private int _currentX = 0;
    private int _currentY = 0;
    private int _currentZ = 0;

    private (int, int, int)? _nextAvailableCell;

    private readonly int _totalAvailableCells;
    private int _fetchedAvailableCells = 0;

    public int X { get; }
    public int Y { get; }
    public int Z { get; }


    public SpatialGrid(int dimX, int dimY, int dimZ)
    {
        this.X = dimX;
        this.Y = dimY;
        this.Z = dimZ;

        _cells = new SpatialGridCell[dimX, dimY, dimZ];

        for (var x = 0; x < dimX; x++)
        {
            for (var y = 0; y < dimY; y++)
            {
                for (var z = 0; z < dimZ; z++)
                {
                    _cells[x, y, z] = new SpatialGridCell
                    {
                        Status = SpatialGridCellStatus.Available
                    };

                    _totalAvailableCells++;
                }
            }
        }

        Task.Run(FindAvailableCell);
    }

    public SpatialGrid(float[,,] spatialArray, Func<int, int, int, SpatialGridCellStatus> availabilityFunc)
    {
        var dimX = spatialArray.GetLength(0);
        var dimY = spatialArray.GetLength(1);
        var dimZ = spatialArray.GetLength(2);

        this.X = dimX;
        this.Y = dimY;
        this.Z = dimZ;

        _cells = new SpatialGridCell[dimX, dimY, dimZ];

        for (var x = 0; x < dimX; x++)
        {
            for (var y = 0; y < dimY; y++)
            {
                for (var z = 0; z < dimZ; z++)
                {
                    _cells[x, y, z] = new SpatialGridCell
                    {
                        Status = availabilityFunc(x, y, z)
                    };

                    if (_cells[x, y, z].Status == SpatialGridCellStatus.Available)
                    {
                        _totalAvailableCells++;
                    }
                }
            }
        }

        Task.Run(FindAvailableCell);
    }

    public (int, int, int)? FetchNextAvailableCell()
    {
        lock (_lockObj)
        {
            if (_nextAvailableCell == null) return null;
            _fetchedAvailableCells++;
            var result = _nextAvailableCell.Value;
            _cells[result.Item1, result.Item2, result.Item3].Status = SpatialGridCellStatus.Processing;
            _nextAvailableCell = null;
        }
        _signal.Set();

        return _nextAvailableCell;
    }

    private void FindAvailableCell()
    {
        while (true)
        {
            lock (_lockObj)
            {
                if (_fetchedAvailableCells >= _totalAvailableCells)
                {
                    _nextAvailableCell = null;
                    break;
                }

                if (_cells[_currentX, _currentY, _currentZ].IsAvailable())
                {
                    _nextAvailableCell = (_currentX, _currentY, _currentZ);
                    break;
                }

                IncrementCurrentCell();
            }
            _signal.Wait();
            _signal.Reset();
        }
    }

    private void IncrementCurrentCell()
    {
        _currentZ++;
        if (_currentZ < _cells.GetLength(2)) return;

        _currentZ = 0;
        _currentY++;
        if (_currentY < _cells.GetLength(1)) return;

        _currentY = 0;
        _currentX++;
        if (_currentX >= _cells.GetLength(0))
        {
            _currentX = 0;
        }
    }

    public void UpdateCellStatus(int x, int y, int z, SpatialGridCellStatus newStatus)
    {
        lock (_lockObj)
        {
            var oldStatus = _cells[x, y, z].Status;
            if (oldStatus == SpatialGridCellStatus.Available && newStatus != SpatialGridCellStatus.Available)
            {
                _fetchedAvailableCells++;
            }
            else if (oldStatus != SpatialGridCellStatus.Available && newStatus == SpatialGridCellStatus.Available)
            {
                _fetchedAvailableCells--;
            }

            _cells[x, y, z].Status = newStatus;
        }
    }

    private class SpatialGridCell
    {
        internal SpatialGridCellStatus Status { get; set; }

        internal bool IsAvailable()
        {
            return Status == SpatialGridCellStatus.Available;
        }
    }
}
