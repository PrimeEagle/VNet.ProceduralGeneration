// ReSharper disable CheckNamespace
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;


internal static partial class Constants
{
    internal static partial class Advanced
    {
        internal static partial class Objects
        {
            internal static partial class Theoretical
            {
                internal static class DysonSphere
                {
                    internal static IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; } = new DotNetGenerator();
                }
            }
        }
    }
}