using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.Constants
{
    internal static partial class ConfigConstants
    {
        internal static class Universe
        {
            internal static float GaussianSigma { get; } = 1.0f;
            internal static double BaselineExpansionRate { get; } = 67.5;                            // km/s/Mpc
            internal static double BaselineCosmicMicrowaveBackground { get; } = 2.735;               // Kelvin
            internal static float MinConnectivityFactor { get; } = 5e9f;
            internal static float MaxConnectivityFactor { get; } = 20e9f;
            internal static float CurvatureFlatPercentage { get; } = 90.0f;
            internal static float CurvatureSphericalPercentage { get; } = 5.0f;
            internal static float CurvatureHyperbolicPercentage { get; } = 5.0f;
            internal static IRandomGenerationAlgorithm RandomGenerator { get; } = new DotNetGenerator();
        }
    }
}