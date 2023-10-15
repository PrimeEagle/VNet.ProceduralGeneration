using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

internal static partial class Constants
{
    internal static partial class Advanced
    {
        internal static partial class Objects
        {
            internal static class Universe
            {
                internal static float CosmicMicrowaveBackgroundThreshold { get; } = 0.001f;
                internal static float CurvatureFlatPercentage { get; } = 90.0f;
                internal static float CurvatureHyperbolicPercentage { get; } = 5.0f;
                internal static float CurvatureSphericalPercentage { get; } = 5.0f;
                internal static int GaussianKernelSize { get; } = 5;
                internal static float GaussianSigma { get; } = 1.0f;
                internal static double InflationEnd { get; } = 3.1709791983765e-39;

                // Kelvin
                internal static double InflationStart { get; } = 3.1709791983765e-43;

                internal static float MaxConnectivityFactor { get; } = 20e9f;
                internal static float MaxCosmicMicrowaveBackground { get; } = 5.00f;
                internal static float MinConnectivityFactor { get; } = 5e9f;

                // years
                // years
                internal static float MinCosmicMicrowaveBackground { get; } = 0.001f; // Kelvin

                // Kelvin


                internal static IRandomGenerationAlgorithm RandomGenerator { get; } = new DotNetGenerator();
            }
        }
    }
}