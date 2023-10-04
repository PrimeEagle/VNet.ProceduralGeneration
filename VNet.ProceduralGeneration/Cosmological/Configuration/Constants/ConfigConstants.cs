﻿namespace VNet.ProceduralGeneration.Cosmological.Configuration.Constants
{
    internal static partial class ConfigConstants
    {
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
        internal static bool ApplyGravitationalEffectsToCosmicWeb { get; } = true;
        internal static string HeightmapFile { get; } = "default_heightmap.png";
        internal static string HeightmapFolder { get; } = "heightmaps";
    }
}