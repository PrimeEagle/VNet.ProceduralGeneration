using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;

// ReSharper disable CheckNamespace
namespace VNet.ProceduralGeneration.Cosmological.Configuration;


internal static partial class Constants
{
    internal static partial class Advanced
    {
        internal static partial class Objects
        {
            internal static class Universe
            {
                internal static Range<float> ConnectivityFactorRange { get; } = new Range<float>(0.0f, 1.0f);
                internal static float CurvatureFlatPercentage { get; } = 95.0f;
                internal static float CurvatureHyperbolicPercentage { get; } = 1.0f;
                internal static float CurvatureSphericalPercentage { get; } = 4.0f;
                internal static Range<float> InflationRange { get; } = new Range<float>(5e9f, 30e9f);
                internal static int ParallelismLevel { get; } = 0;
                internal static IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; } = new DotNetGenerator();
            }
        }
    }
}