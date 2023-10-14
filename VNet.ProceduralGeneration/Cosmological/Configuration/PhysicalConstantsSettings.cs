using System.ComponentModel;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class PhysicalConstantsSettings : ISettings
{
    public PhysicalConstantsSettings()
    {
        c = ConfigConstants.PhysicalConstants.c;
        C = ConfigConstants.PhysicalConstants.C;
        H0 = ConfigConstants.PhysicalConstants.H0;
        h = ConfigConstants.PhysicalConstants.h;
        kB = ConfigConstants.PhysicalConstants.kB;
        G = ConfigConstants.PhysicalConstants.G;
        BaselineCosmicMicrowaveBackground = ConfigConstants.PhysicalConstants.BaselineCosmicMicrowaveBackground;
        BaselineAgeOfUniverse = ConfigConstants.PhysicalConstants.BaselineAgeOfUniverse;
    }

    [DisplayName("c (Speed of Light in a Vacuum)")]
    [Tooltip("The speed of light.")]
    public float c { get; init; }

    [DisplayName("C (Zero Point Magnitude Constant")]
    [Tooltip("The zero point magnitude constant.")]
    public float C { get; init; }

    [DisplayName("H\u2080 (Hubble Constant)")]
    [Tooltip("The Hubble constant.")]
    public float H0 { get; init; }

    [DisplayName("h (Planck Constant)")]
    [Tooltip("The zero point magnitude constant.")]
    public double h { get; init; }

    [DisplayName("kB (Boltzmann Constant)")]
    [Tooltip("The Boltzmann Constant.")]
    public float kB { get; init; }

    [DisplayName("G (Gravitational Constant)")]
    [Tooltip("The gravitational constant.")]
    public float G { get; init; }

    [DisplayName("Baseline Cosmic Microwave Background (CMB)")]
    [Tooltip("The cosmic microwave background of the real universe.")]
    public float BaselineCosmicMicrowaveBackground { get; init; }

    [DisplayName("Baseline Age of the Universe")]
    [Tooltip("The age of the real universe.")]
    public float BaselineAgeOfUniverse { get; init; }
}