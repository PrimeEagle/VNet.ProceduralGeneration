namespace VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

internal static partial class ConfigConstants
{
    internal static class Basic
    {
        internal static float DimensionX { get; } = 100f;
        internal static float DimensionY { get; } = 100f;
        internal static float DimensionZ { get; } = 100f;
        internal static float MinDarkEnergyPercent { get; } = 65.0f;
        internal static float MaxDarkEnergyPercent { get; } = 75.0f;
        internal static float MinDarkMatterPercent { get; } = 20.0f;
        internal static float MaxDarkMatterPercent { get; } = 30.0f;
        internal static float MinBaryonicMatterPercent { get; } = 4.0f;
        internal static float MaxBaryonicMatterPercent { get; } = 6.0f;
        internal static float MinUniverseAge { get; } = 5e9f; // years
        internal static float MaxUniverseAge { get; } = 20e9f; // years
        internal static bool ApplyGravitationalEffects { get; } = true;
        internal static string HeightmapFile { get; } = "default_heightmap.png";
        internal static string HeightmapFolder { get; } = "heightmaps";
        internal static string LuaPluginFolder { get; } = "plugins_lua";
        internal static string CSharpPluginFolder { get; } = "plugins_csharp";
    }
}