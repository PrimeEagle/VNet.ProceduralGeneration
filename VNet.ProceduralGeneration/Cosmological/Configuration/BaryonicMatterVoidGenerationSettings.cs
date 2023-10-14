using System.ComponentModel;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class BaryonicMatterVoidGenerationSettings : ISettings
{
    public BaryonicMatterVoidGenerationSettings()
    {
        CountAgeFactor = ConfigConstants.BaryonicMatterVoid.CountAgeFactor;
        CountMassFactor = ConfigConstants.BaryonicMatterVoid.CountMassFactor;
        CountSizeFactor = ConfigConstants.BaryonicMatterVoid.CountSizeFactor;
        CountBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterVoid.CountBaryonicMatterPercentFactor;
        CountDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterVoid.CountDarkEnergyPercentFactor;
    }

    [DisplayName("Count Age Factor")]
    [Tooltip("Weighting factor for the age of the universe on baryonic matter (normal matter) void count. Higher value results in more voids.")]
    public double CountAgeFactor { get; init; }

    [DisplayName("Count Mass Factor")]
    [Tooltip("Weighting factor for the mass of the universe on baryonic matter (normal matter) void count. Higher value results in more voids.")]
    public double CountMassFactor { get; init; }

    [DisplayName("Count Size Factor")]
    [Tooltip("Weighting factor for the size of the universe on baryonic matter (normal matter) void count. Higher value results in more voids.")]
    public double CountSizeFactor { get; init; }

    [DisplayName("Count Baryonic Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of baryonic matter (normal matter) in the universe on baryonic matter (normal matter) void count. Higher value results in less voids.")]
    public double CountBaryonicMatterPercentFactor { get; init; }

    [DisplayName("Count Dark Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark matter in the universe on baryonic matter (normal matter) void count. Higher value results in less voids.")]
    public double CountDarkMatterPercentFactor { get; init; }

    [DisplayName("Count Dark Energy Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark energy in the universe on baryonic matter (normal matter) void count. Higher value results in more voids.")]
    public double CountDarkEnergyPercentFactor { get; init; }
}