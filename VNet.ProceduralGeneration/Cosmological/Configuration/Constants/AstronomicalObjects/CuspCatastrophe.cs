// ReSharper disable CheckNamespace
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;


internal static partial class Constants
{
    internal static partial class Advanced
    {
        internal static partial class Objects
        {
            internal static class CuspCatastrophe
            {
                internal static int ParallelismLevel { get; } = 0;
                internal static IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; } = new DotNetGenerator();
            }
        }
    }
}