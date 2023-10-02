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
        }
    }
}