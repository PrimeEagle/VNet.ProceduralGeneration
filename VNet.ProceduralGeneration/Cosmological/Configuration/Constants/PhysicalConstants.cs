namespace VNet.ProceduralGeneration.Cosmological.Configuration;

internal static partial class Constants
{
    internal static partial class Advanced
    {
        internal static class PhysicalConstants
        {
            internal static float BaselineAgeOfUniverse { get; } = 13.8e9f;
            internal static float BaselineCosmicMicrowaveBackground { get; } = 2.7255f;
            internal static float c { get; } = 63121021f; // AU/year
            internal static float C { get; } = 4.83f;
            internal static float G { get; } = 6.67430e-11f;
            internal static double h { get; } = 6.62607015e-34;
            internal static float H0 { get; } = 70f; // (km/s)/Mpc

            // JHz⁻¹
            internal static float kB { get; } = 0.380649e-23f; // JK⁻¹

            // Nm²kg⁻²
            // Kelvin
            // years
        }
    }
}