using VNet.Mathematics.Randomization.Generation;
using VNet.Scientific.Noise;
using VNet.Scientific.Noise.Other;

// ReSharper disable CheckNamespace
namespace VNet.ProceduralGeneration.Cosmological.Configuration;

internal static partial class Constants
{
    internal static partial class Advanced
    {
        internal static partial class Objects
        {
            internal static partial class CosmicWeb
            {
                internal static float BaryonicMatterVoidDiameterRange { get; } = 2e13f;
                internal static float BaryonicMatterVoidOverlapRange { get; } = 1e8f;
                internal static float DarkMatterVoidDiameterRange { get; } = 2e13f;
                internal static float DarkMatterVoidOverlapRange { get; } = 1e8f;
                internal static float BaryonicMatterVoidDiameterRange { get; } = 1e12f;
                internal static float BaryonicMatterVoidOverlapRange { get; } = 1.0f;
                internal static float DarkMatterVoidDiameterRange { get; } = 1e12f;
                internal static float DarkMatterVoidOverlapRange { get; } = 1.0f;
                internal static float PercentageOfOverlappingBaryonicMatterVoids { get; } = 60.0f;
                internal static float PercentageOfOverlappingDarkMatterVoids { get; } = 80.0f;
                internal static float PercentageOfVolumeCoveredByBaryonicMatterVoids { get; } = 40.0f;
                internal static float PercentageOfVolumeCoveredByDarkMatterMatterVoids { get; } = 75.0f;
            }
        }
    }
}