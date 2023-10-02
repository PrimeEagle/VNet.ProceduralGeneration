namespace VNet.ProceduralGeneration.Cosmological.Configuration.Constants
{
    internal static partial class ConfigConstants
    {
        internal static class DarkMatterNode
        {
            internal static float CountTolerancePercentage { get; } = 10.0f;
            internal static float CountAgeFactor { get; } = 6.0e-9f;
            internal static float CountMassFactor { get; } = 1 / 1e30f;
            internal static float CountSizeFactor { get; } = 1 / 1e9f;
            internal static float CountBaryonicMatterPercentFactor { get; } = 200;
            internal static float CountDarkMatterPercentFactor { get; } = 100;
            internal static float CountDarkEnergyPercentFactor { get; } = 100;
            internal static float TopologyGradientMagnitudeThresholdFactor { get; } = 0.2f;
            internal static float TopologyIntensityThresholdFactor { get; } = 1.2f;
            internal static float TopologyMergeDistanceThresholdFactor { get; } = 0.2f;
            internal static float TopologyMinDistanceThresholdFactor { get; } = 1.2f;
            internal static float TopologyMaxPositionalOffset { get; } = 0.2f;
            internal static float TopologyZVariancePercent { get; } = 100.0f;
        }
    }
}