namespace VNet.ProceduralGeneration.Cosmological
{
    public class SpatialGridCell
    {
        public SpatialGridCellStatus Status { get; private set; } = SpatialGridCellStatus.Available;


        public bool IsAvailable()
        {
            return Status == SpatialGridCellStatus.Available;
        }

        public void MarkProcessing()
        {
            Status = SpatialGridCellStatus.Processing;
        }

        public void MarkAvailable()
        {
            Status = SpatialGridCellStatus.Available;
        }

        public void MarkUnavailable()
        {
            Status = SpatialGridCellStatus.Unavailable;
        }

        public void MarkDone()
        {
            Status = SpatialGridCellStatus.Done;
        }
    }
}