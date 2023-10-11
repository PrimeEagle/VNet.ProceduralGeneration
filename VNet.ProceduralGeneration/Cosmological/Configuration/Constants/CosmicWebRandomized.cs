using VNet.Mathematics.Randomization.Generation;
using VNet.Scientific.Noise;
using VNet.Scientific.Noise.Other;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.Constants
{
    internal static partial class ConfigConstants
    {
        internal static class CosmicWebRandomized
        {
            private static readonly PerlinNoiseAlgorithmArgs _noiseAlgorithmArgs = new()
            {
                Octave = 8
            };

            internal static IRandomGenerationAlgorithm BaryonicMatterNodeRandomizationAlgorithm { get; } = new DotNetGenerator();
            internal static INoiseAlgorithm BaryonicMatterNodeNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
            internal static IRandomGenerationAlgorithm BaryonicMatterFilamentRandomizationAlgorithm { get; } = new DotNetGenerator();
            internal static INoiseAlgorithm BaryonicMatterFilamentNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
            internal static IRandomGenerationAlgorithm BaryonicMatterSheetRandomizationAlgorithm { get; } = new DotNetGenerator();
            internal static INoiseAlgorithm BaryonicMatterSheetNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
            internal static IRandomGenerationAlgorithm BaryonicMatterVoidRandomizationAlgorithm { get; } = new DotNetGenerator();
            internal static INoiseAlgorithm BaryonicMatterVoidNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
            internal static IRandomGenerationAlgorithm DarkMatterNodeRandomizationAlgorithm { get; } = new DotNetGenerator();
            internal static INoiseAlgorithm DarkMatterNodeNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
            internal static IRandomGenerationAlgorithm DarkMatterFilamentRandomizationAlgorithm { get; } = new DotNetGenerator();
            internal static INoiseAlgorithm DarkMatterFilamentNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
            internal static IRandomGenerationAlgorithm DarkMatterSheetRandomizationAlgorithm { get; } = new DotNetGenerator();
            internal static INoiseAlgorithm DarkMatterSheetNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
            internal static IRandomGenerationAlgorithm DarkMatterVoidRandomizationAlgorithm { get; } = new DotNetGenerator();
            internal static INoiseAlgorithm DarkMatterVoidNoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
        }
    }
}