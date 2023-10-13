using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

internal static partial class ConfigConstants
{
    internal static class CosmicWeb
    {
        internal static IRandomGenerationAlgorithm RandomGenerator { get; } = new DotNetGenerator();
        internal static CosmicWebGenerationMethod CosmicWebGenerationMethod { get; } = CosmicWebGenerationMethod.Random;
    }
}