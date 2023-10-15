using System.Numerics;
using VNet.Configuration;
// ReSharper disable CheckNamespace

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

internal static partial class Constants
{
    internal static partial class Basic
    {
        internal static bool ApplyGravitationalEffects { get; } = true;
        internal static Vector3 MapDimensions { get; } = new Vector3(100f, 100f, 100f);
        internal static string HeightmapFile { get; } = "default_heightmap.png";
        internal static string HeightmapFolder { get; } = "heightmaps";
        internal static Range<float> BaryonicMatterPercentRange { get; } = new Range<float>(5.2f, 5.2f);
        internal static Range<float> DarkMatterPercentRange { get; } = new Range<float>(26.5f, 26.5f);
        internal static Range<float> DarkEnergyPercentRange { get; } = new Range<float>(68.6f, 68.6f);
        internal static Range<float> UniverseAgeRange { get; } = new Range<float>(5e9f, 30e9f);                                                  // years
    }
}