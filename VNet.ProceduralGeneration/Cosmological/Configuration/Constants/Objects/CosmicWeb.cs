using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

internal static partial class Constants
{
    internal static partial class Advanced
    {
        internal static partial class Objects
        {
            internal static partial class CosmicWeb
            {
                internal static CosmicWebGenerationMethod CosmicWebGenerationMethod { get; } = CosmicWebGenerationMethod.Random;
                internal static IRandomGenerationAlgorithm RandomGenerator { get; } = new DotNetGenerator();
            }
        }
    }
}