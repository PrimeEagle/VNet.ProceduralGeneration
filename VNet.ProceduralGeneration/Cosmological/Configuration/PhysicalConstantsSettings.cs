using System.ComponentModel;
using VNet.Configuration;
using VNet.Configuration.Attributes;
#pragma warning disable IDE1006


namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class PhysicalConstantsSettings : ISettings
{
    [DisplayName("Baseline Age of the Universe")]
    [Tooltip("The age of the real universe.")]
    public float BaselineAgeOfUniverse { get; init; }

    [DisplayName("Baseline Cosmic Microwave Background (CMB)")]
    [Tooltip("The cosmic microwave background of the real universe.")]
    public float BaselineCosmicMicrowaveBackground { get; init; }

    [DisplayName("c (Speed of Light in a Vacuum)")]
    [Tooltip("The speed of light.")]
    // ReSharper disable once InconsistentNaming
    public float c { get; init; }

    [DisplayName("C (Zero Point Magnitude Constant")]
    [Tooltip("The zero point magnitude constant.")]
    public float C { get; init; }

    [DisplayName("G (Gravitational Constant)")]
    [Tooltip("The gravitational constant.")]
    public float G { get; init; }

    [DisplayName("h (Planck Constant)")]
    [Tooltip("The zero point magnitude constant.")]
    // ReSharper disable once InconsistentNaming
    public double h { get; init; }

    [DisplayName("H\u2080 (Hubble Constant)")]
    [Tooltip("The Hubble constant.")]
    public float H0 { get; init; }

    [DisplayName("kB (Boltzmann Constant)")]
    [Tooltip("The Boltzmann Constant.")]
    // ReSharper disable once InconsistentNaming
    public float kB { get; init; }

    public PhysicalConstantsSettings()
    {
        c = Constants.Advanced.PhysicalConstants.c;
        C = Constants.Advanced.PhysicalConstants.C;
        H0 = Constants.Advanced.PhysicalConstants.H0;
        h = Constants.Advanced.PhysicalConstants.h;
        kB = Constants.Advanced.PhysicalConstants.kB;
        G = Constants.Advanced.PhysicalConstants.G;
        BaselineCosmicMicrowaveBackground = Constants.Advanced.PhysicalConstants.BaselineCosmicMicrowaveBackground;
        BaselineAgeOfUniverse = Constants.Advanced.PhysicalConstants.BaselineAgeOfUniverse;
    }
}