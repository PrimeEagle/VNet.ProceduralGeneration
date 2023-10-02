using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.Constants
{
    internal static partial class ConfigConstants
    {
        internal static class Application
        {
            internal static int MaxDegreesOfParallelismLevel1 { get; } = Environment.ProcessorCount;
            internal static int MaxDegreesOfParallelismLevel2 { get; } = Environment.ProcessorCount - 2 > 1 ? Environment.ProcessorCount - 2 : 1;
            internal static int MaxDegreesOfParallelismLevel3 { get; } = Environment.ProcessorCount - 4 > 1 ? Environment.ProcessorCount - 4 : 1;
            internal static int MaxDegreesOfParallelismLevel4 { get; } = Environment.ProcessorCount - 6 > 1 ? Environment.ProcessorCount - 6 : 1;
            internal static IRandomGenerationAlgorithm RandomGenerator { get; } = new DotNetGenerator();
        }
    }
}