using System.ComponentModel;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class DarkMatterVoidGenerationSettings : ISettings
{
    public DarkMatterVoidGenerationSettings()
    {
        CountAgeFactor = ConfigConstants.DarkMatterVoid.CountAgeFactor;
        CountMassFactor = ConfigConstants.DarkMatterVoid.CountMassFactor;
        CountSizeFactor = ConfigConstants.DarkMatterVoid.CountSizeFactor;
        CountDarkMatterPercentFactor = ConfigConstants.DarkMatterVoid.CountDarkMatterPercentFactor;
        CountDarkEnergyPercentFactor = ConfigConstants.DarkMatterVoid.CountDarkEnergyPercentFactor;
    }

    [DisplayName("Count Age Factor")]
    [Tooltip("Weighting factor for the age of the universe on dark matter void count. Higher value results in more voids.")]
    public double CountAgeFactor { get; init; }

    [DisplayName("Count Mass Factor")]
    [Tooltip("Weighting factor for the age of the universe on dark matter void count. Higher value results in more voids.")]
    public double CountMassFactor { get; init; }

    [DisplayName("Count Size Factor")]
    [Tooltip("Weighting factor for the size of the universe on dark matter void count. Higher value results in more voids.")]
    public double CountSizeFactor { get; init; }

    [DisplayName("Count Baryonic Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter void count. Higher value results in more voids.")]
    public double CountBaryonicMatterPercentFactor { get; init; }

    [DisplayName("Count Dark Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter void count. Higher value results in less voids.")]
    public double CountDarkMatterPercentFactor { get; init; }

    [DisplayName("Count Dark Energy Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark energy in the universe on dark matter void count. Higher value results in more voids.")]
    public double CountDarkEnergyPercentFactor { get; init; }
}