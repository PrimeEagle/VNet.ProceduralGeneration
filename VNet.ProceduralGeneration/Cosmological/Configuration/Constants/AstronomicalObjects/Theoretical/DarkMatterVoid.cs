// ReSharper disable CheckNamespace
using VNet.Configuration;
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
                internal static class DarkMatterVoid
                {
                    internal static VNet.Configuration.Range<float> DiameterRange { get; } = new Range<float>(1.2e12f, 1.2e13f);
                    internal static IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; } = new DotNetGenerator();
                }
            }
        }
    }
}