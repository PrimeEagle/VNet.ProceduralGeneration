namespace VNet.ProceduralGeneration.Cosmological;

public class SpatialGrid
{
    private SpatialGridCell[,,] cells;
    private object lockObj = new object();
    private ManualResetEventSlim signal = new ManualResetEventSlim(false);

    private int currentX = 0;
    private int currentY = 0;
    private int currentZ = 0;

    private (int, int, int)? nextAvailableCell;

    private int totalAvailableCells;
    private int fetchedAvailableCells = 0;

    public SpatialGrid(int dimX, int dimY, int dimZ)
    {
        cells = new SpatialGridCell[dimX, dimY, dimZ];

        for (int x = 0; x < dimX; x++)
        {
            for (int y = 0; y < dimY; y++)
            {
                for (int z = 0; z < dimZ; z++)
                {
                    cells[x, y, z] = new SpatialGridCell();
                    cells[x, y, z].Status = SpatialGridCellStatus.Available;

                    totalAvailableCells++;
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

        cells = new SpatialGridCell[dimX, dimY, dimZ];

        for (int x = 0; x < dimX; x++)
        {
            for (int y = 0; y < dimY; y++)
            {
                for (int z = 0; z < dimZ; z++)
                {
                    cells[x, y, z] = new SpatialGridCell
                    {
                        Status = availabilityFunc(x, y, z)
                    };

                    if (cells[x, y, z].Status == SpatialGridCellStatus.Available)
                    {
                        totalAvailableCells++;
                    }
                }
            }
        }

        Task.Run(FindAvailableCell);
    }

    public (int, int, int)? FetchNextAvailableCell()
    {
        lock (lockObj)
        {
            if (nextAvailableCell == null) return null;
            fetchedAvailableCells++;
            var result = nextAvailableCell.Value;
            cells[result.Item1, result.Item2, result.Item3].Status = SpatialGridCellStatus.Processing;
            nextAvailableCell = null;
        }
        signal.Set();

        return nextAvailableCell;
    }

    private void FindAvailableCell()
    {
        while (true)
        {
            lock (lockObj)
            {
                if (fetchedAvailableCells >= totalAvailableCells)
                {
                    nextAvailableCell = null;
                    break;
                }

                if (cells[currentX, currentY, currentZ].IsAvailable())
                {
                    nextAvailableCell = (currentX, currentY, currentZ);
                    break;
                }

                IncrementCurrentCell();
            }
            signal.Wait();
            signal.Reset();
        }
    }

    private void IncrementCurrentCell()
    {
        currentZ++;
        if (currentZ >= cells.GetLength(2))
        {
            currentZ = 0;
            currentY++;
            if (currentY >= cells.GetLength(1))
            {
                currentY = 0;
                currentX++;
                if (currentX >= cells.GetLength(0))
                {
                    currentX = 0;
                }
            }
        }
    }

    public void UpdateCellStatus(int x, int y, int z, SpatialGridCellStatus newStatus)
    {
        lock (lockObj)
        {
            var oldStatus = cells[x, y, z].Status;
            if (oldStatus == SpatialGridCellStatus.Available && newStatus != SpatialGridCellStatus.Available)
            {
                fetchedAvailableCells++;
            }
            else if (oldStatus != SpatialGridCellStatus.Available && newStatus == SpatialGridCellStatus.Available)
            {
                fetchedAvailableCells--;
            }

            cells[x, y, z].Status = newStatus;
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
