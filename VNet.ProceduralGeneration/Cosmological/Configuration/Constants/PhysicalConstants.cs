namespace VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

internal static partial class ConfigConstants
{
    internal static class PhysicalConstants
    {
        internal static float c { get; } = 63121021f; // AU/year
        internal static float C { get; } = 4.83f;
        internal static float H0 { get; } = 70f; // (km/s)/Mpc
        internal static double h { get; } = 6.62607015e-34; // JHz⁻¹
        internal static float kB { get; } = 0.380649e-23f; // JK⁻¹
        internal static float G { get; } = 6.67430e-11f; // Nm²kg⁻²
        internal static float BaselineCosmicMicrowaveBackground { get; } = 2.7255f; // Kelvin
        internal static float BaselineAgeOfUniverse { get; } = 13.8e9f; // years
    }
}