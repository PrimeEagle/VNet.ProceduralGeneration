namespace VNet.ProceduralGeneration.Cosmological
{
    public class SpatialGrid
    {
        private int _resolutionX;
        private int _resolutionY;
        private int _resolutionZ;

        public SpatialGridCell[,,] Cells { get; private set; }

        public SpatialGrid(int resolutionX, int resolutionY, int resolutionZ)
        {
            _resolutionX = resolutionX;
            _resolutionY = resolutionY;
            _resolutionZ = resolutionZ;

            Cells = new SpatialGridCell[_resolutionX, _resolutionY, _resolutionZ];
            for (var x = 0; x < _resolutionX; x++)
            {
                for (var y = 0; y < _resolutionY; y++)
                {
                    for (var z = 0; z < _resolutionZ; z++)
                    {
                        Cells[x, y, z] = new SpatialGridCell();
                    }
                }
            }
        }

        public SpatialGridCell GetCell(int x, int y, int z)
        {
            if (x >= 0 && x < _resolutionX &&
                y >= 0 && y < _resolutionY &&
                z >= 0 && z < _resolutionZ)
            {
                return Cells[x, y, z];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Indices out of grid bounds.");
            }
        }
    }
}