namespace VNet.ProceduralGeneration.Cosmological
{
    public class NodeConfiguration
    {
        public float NodeDensityThresholdFactor { get; init; }
        public float NodeGradientMagnitudeThresholdFactor { get; init; }
        public float NodeMaxPositionalOffset { get; init; }
        public float NodeSeedMergeDistanceThreshold { get; init; }
        public float NodeSeedMinDistanceThreshold { get; init; }
    }
}