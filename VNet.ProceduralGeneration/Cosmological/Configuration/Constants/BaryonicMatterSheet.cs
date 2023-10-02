namespace VNet.ProceduralGeneration.Cosmological.Configuration.Constants
{
    internal static partial class ConfigConstants
    {
        internal static class BaryonicMatterSheet
        {
            internal static double CountAgeFactor { get; } = 5.0e-9;
            internal static double CountMassFactor { get; } = 1 / 1e30;
            internal static double CountSizeFactor { get; } = 1 / 1e9;
            internal static double CountBaryonicMatterPercentFactor { get; } = 100;
            internal static double CountDarkMatterPercentFactor { get; } = 150;
            internal static double CountDarkEnergyPercentFactor { get; } = 100;
        }
    }
}