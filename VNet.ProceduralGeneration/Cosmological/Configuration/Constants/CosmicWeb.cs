using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.Constants
{
    internal static partial class ConfigConstants
    {
        internal static class CosmicWeb
        {
            internal static IRandomGenerationAlgorithm RandomGenerator { get; } = new DotNetGenerator();
        }
    }
}