namespace VNet.ProceduralGeneration.Cosmological.Configuration.Constants
{
    internal static partial class ConfigConstants
    {
        internal static int MaxDegreesOfParallelismLevel1 { get; } = Environment.ProcessorCount;
        internal static int MaxDegreesOfParallelismLevel2 { get; } = Environment.ProcessorCount - 2 > 1 ? Environment.ProcessorCount - 2 : 1;
        internal static int MaxDegreesOfParallelismLevel3 { get; } = Environment.ProcessorCount - 4 > 1 ? Environment.ProcessorCount - 4 : 1;
        internal static int MaxDegreesOfParallelismLevel4 { get; } = Environment.ProcessorCount - 6 > 1 ? Environment.ProcessorCount - 6 : 1;
        internal static float DimensionX { get; } = 100f;
        internal static float DimensionY { get; } = 100f;
        internal static float DimensionZ { get; } = 100f;
        internal static double MinDarkEnergyPercent { get; } = 65.0;
        internal static double MaxDarkEnergyPercent { get; } = 75.0;
        internal static double MinDarkMatterPercent { get; } = 20.0;
        internal static double MaxDarkMatterPercent { get; } = 30.0;
        internal static double MinBaryonicMatterPercent { get; } = 4.0;
        internal static double MaxBaryonicMatterPercent { get; } = 6.0;
        internal static float MinUniverseAge { get; } = 5e9f;                                    // years
        internal static float MaxUniverseAge { get; } = 20e9f;                                   // years
        internal static double BaselineExpansionRate { get; } = 67.5;                            // km/s/Mpc
        internal static double BaselineCosmicMicrowaveBackground { get; } = 2.735;               // Kelvin
        internal static float MinConnectivityFactor { get; } = 5e9f;
        internal static float MaxConnectivityFactor { get; } = 20e9f;
    }
}