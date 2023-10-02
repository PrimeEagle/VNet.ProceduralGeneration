namespace VNet.ProceduralGeneration.Cosmological.Configuration.Constants
{
    internal static partial class ConfigConstants
    {
        internal static class DarkMatterNode
        {
            internal static double CountAgeFactor { get; } = 6.0e-9;
            internal static double CountMassFactor { get; } = 1 / 1e30;
            internal static double CountSizeFactor { get; } = 1 / 1e9;
            internal static double CountBaryonicMatterPercentFactor { get; } = 200;
            internal static double CountDarkMatterPercentFactor { get; } = 100;
            internal static double CountDarkEnergyPercentFactor { get; } = 100;
            internal static float TopologyGradientMagnitudeThresholdFactor { get; } = 0.2f;
            internal static float TopologyIntensityThresholdFactor { get; } = 1.2f;
            internal static float TopologyMergeDistanceThresholdFactor { get; } = 0.2f;
            internal static float TopologyMinDistanceThresholdFactor { get; } = 1.2f;
            internal static float TopologyMaxPositionalOffset { get; } = 0.2f;
        }
    }
}