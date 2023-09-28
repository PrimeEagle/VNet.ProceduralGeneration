namespace VNet.ProceduralGeneration.Cosmological;

public class SpatialGrid
{
    private readonly SpatialGridCell[,,] _grid;
    private readonly object _lockObject = new object();

    public SpatialGridCell this[int x, int y, int z] => _grid[x, y, z];


    public SpatialGrid(float[,,] sourceArray)
    {
        var xDim = sourceArray.GetLength(0);
        var yDim = sourceArray.GetLength(1);
        var zDim = sourceArray.GetLength(2);

        _grid = new SpatialGridCell[xDim, yDim, zDim];

        for (var x = 0; x < xDim; x++)
        {
            for (var y = 0; y < yDim; y++)
            {
                for (var z = 0; z < zDim; z++)
                {
                    _grid[x, y, z] = new SpatialGridCell();
                }
            }
        }
    }

    public SpatialGrid(int xDim, int yDim, int zDim)
    {
        _grid = new SpatialGridCell[xDim, yDim, zDim];

        for (var x = 0; x < xDim; x++)
        {
            for (var y = 0; y < yDim; y++)
            {
                for (var z = 0; z < zDim; z++)
                {
                    _grid[x, y, z] = new SpatialGridCell();
                }
            }
        }
    }

    public (int, int, int)? GetNextAvailable()
    {
        lock (_lockObject)
        {
            for (var x = 0; x < _grid.GetLength(0); x++)
            {
                for (var y = 0; y < _grid.GetLength(1); y++)
                {
                    for (var z = 0; z < _grid.GetLength(2); z++)
                    {
                        if (!_grid[x, y, z].IsAvailable()) continue;

                        _grid[x, y, z].MarkProcessing();
                        return (x, y, z);
                    }
                }
            }
        }
        return null;
    }

    public void MarkDone(int x, int y, int z)
    {
        _grid[x, y, z].MarkDone();
    }
}