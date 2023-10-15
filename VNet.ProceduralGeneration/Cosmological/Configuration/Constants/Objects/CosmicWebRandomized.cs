using VNet.Mathematics.Randomization.Generation;
using VNet.Scientific.Noise;
using VNet.Scientific.Noise.Other;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

internal static partial class Constants
{
    internal static partial class Advanced
    {
        internal static partial class Objects
        {
            internal static partial class CosmicWeb
            {
                private static readonly PerlinNoiseAlgorithmArgs _noiseAlgorithmArgs = new()
                {
                    Octave = 8
                };

                internal static INoiseAlgorithm BaryonicMatterFilamentNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
                internal static IRandomGenerationAlgorithm BaryonicMatterFilamentRandomizationAlgorithm { get; } = new DotNetGenerator();
                internal static INoiseAlgorithm BaryonicMatterNodeNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
                internal static IRandomGenerationAlgorithm BaryonicMatterNodeRandomizationAlgorithm { get; } = new DotNetGenerator();
                internal static IRandomGenerationAlgorithm BaryonicMatterRandomizationAlgorithm { get; } = new DotNetGenerator();
                internal static INoiseAlgorithm BaryonicMatterSheetNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
                internal static IRandomGenerationAlgorithm BaryonicMatterSheetRandomizationAlgorithm { get; } = new DotNetGenerator();
                internal static INoiseAlgorithm BaryonicMatterVoidNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
                internal static IRandomGenerationAlgorithm BaryonicMatterVoidRandomizationAlgorithm { get; } = new DotNetGenerator();
                internal static INoiseAlgorithm DarkMatterFilamentNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
                internal static IRandomGenerationAlgorithm DarkMatterFilamentRandomizationAlgorithm { get; } = new DotNetGenerator();
                internal static INoiseAlgorithm DarkMatterNodeNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
                internal static IRandomGenerationAlgorithm DarkMatterNodeRandomizationAlgorithm { get; } = new DotNetGenerator();
                internal static IRandomGenerationAlgorithm DarkMatterRandomizationAlgorithm { get; } = new DotNetGenerator();
                internal static INoiseAlgorithm DarkMatterSheetNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
                internal static IRandomGenerationAlgorithm DarkMatterSheetRandomizationAlgorithm { get; } = new DotNetGenerator();
                internal static INoiseAlgorithm DarkMatterVoidNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
                internal static IRandomGenerationAlgorithm DarkMatterVoidRandomizationAlgorithm { get; } = new DotNetGenerator();
                internal static float MaximumBaryonicMatterVoidDiameter { get; } = 2e13f;
                internal static float MaximumBaryonicMatterVoidOverlap { get; } = 1e8f;
                internal static float MaximumDarkMatterVoidDiameter { get; } = 2e13f;
                internal static float MaximumDarkMatterVoidOverlap { get; } = 1e8f;
                internal static float MinimumBaryonicMatterVoidDiameter { get; } = 1e12f;
                internal static float MinimumBaryonicMatterVoidOverlap { get; } = 1.0f;
                internal static float MinimumDarkMatterVoidDiameter { get; } = 1e12f;
                internal static float MinimumDarkMatterVoidOverlap { get; } = 1.0f;
                internal static float PercentageOfOverlappingBaryonicMatterVoids { get; } = 60.0f;
                internal static float PercentageOfOverlappingDarkMatterVoids { get; } = 80.0f;
                internal static float PercentageOfVolumeCoveredByBaryonicMatterVoids { get; } = 40.0f;
                internal static float PercentageOfVolumeCoveredByDarkMatterMatterVoids { get; } = 75.0f;
            }
        }
    }
}