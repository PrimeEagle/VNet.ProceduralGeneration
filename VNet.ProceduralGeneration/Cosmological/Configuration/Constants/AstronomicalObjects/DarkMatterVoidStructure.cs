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
                internal static class DarkMatterVoidStructure
                {
                    internal static VNet.Configuration.Range<float> OverlappingPercentRange { get; } = new VNet.Configuration.Range<float>(60.0f, 80.0f);
                    internal static VNet.Configuration.Range<float> OverlapRange { get; } = new VNet.Configuration.Range<float>(1.0f, 1.0e10f);
                    internal static IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; } = new DotNetGenerator();
                    internal static VNet.Configuration.Range<float> VolumeCoveredByPercentRange { get; } = new VNet.Configuration.Range<float>(40.0f, 65.0f);
                }
            }
        }
    }
}