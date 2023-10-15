namespace VNet.ProceduralGeneration.Cosmological.Configuration;

internal static partial class Constants
{
    internal static partial class Basic
    {
        internal static bool ApplyGravitationalEffects { get; } = true;
        internal static float DimensionX { get; } = 100f;
        internal static float DimensionY { get; } = 100f;
        internal static float DimensionZ { get; } = 100f;
        internal static string HeightmapFile { get; } = "default_heightmap.png";
        internal static string HeightmapFolder { get; } = "heightmaps";
        internal static float MaxBaryonicMatterPercent { get; } = 6.0f;
        internal static float MaxDarkEnergyPercent { get; } = 75.0f;
        internal static float MaxDarkMatterPercent { get; } = 30.0f;
        internal static float MaxUniverseAge { get; } = 20e9f;
        internal static float MinBaryonicMatterPercent { get; } = 4.0f;
        internal static float MinDarkEnergyPercent { get; } = 65.0f;
        internal static float MinDarkMatterPercent { get; } = 20.0f;
        internal static float MinUniverseAge { get; } = 5e9f; // years
                                                              // years
    }
}