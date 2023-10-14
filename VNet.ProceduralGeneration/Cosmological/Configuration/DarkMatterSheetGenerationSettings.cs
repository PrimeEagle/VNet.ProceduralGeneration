using System.ComponentModel;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class DarkMatterSheetGenerationSettings : ISettings
{
    public DarkMatterSheetGenerationSettings()
    {
        CountAgeFactor = ConfigConstants.DarkMatterSheet.CountAgeFactor;
        CountMassFactor = ConfigConstants.DarkMatterSheet.CountMassFactor;
        CountSizeFactor = ConfigConstants.DarkMatterSheet.CountSizeFactor;
        CountBaryonicMatterPercentFactor = ConfigConstants.DarkMatterSheet.CountBaryonicMatterPercentFactor;
        CountDarkMatterPercentFactor = ConfigConstants.DarkMatterSheet.CountDarkMatterPercentFactor;
        CountDarkEnergyPercentFactor = ConfigConstants.DarkMatterSheet.CountDarkEnergyPercentFactor;
    }

    [DisplayName("Count Age Factor")]
    [Tooltip("Weighting factor for the age of the universe on dark matter sheet count. Higher value results in more sheets.")]
    public double CountAgeFactor { get; init; }

    [DisplayName("Count Mass Factor")]
    [Tooltip("Weighting factor for the age of the universe on dark matter sheet count. Higher value results in more sheets.")]
    public double CountMassFactor { get; init; }

    [DisplayName("Count Size Factor")]
    [Tooltip("Weighting factor for the size of the universe on dark matter sheet count. Higher value results in more sheets.")]
    public double CountSizeFactor { get; init; }

    [DisplayName("Count Baryonic Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter sheet count. Higher value results in more sheets.")]
    public double CountBaryonicMatterPercentFactor { get; init; }

    [DisplayName("Count Dark Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter sheet count. Higher value results in less sheets.")]
    public double CountDarkMatterPercentFactor { get; init; }

    [DisplayName("Count Dark Energy Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark energy in the universe on dark matter sheet count. Higher value results in more sheets.")]
    public double CountDarkEnergyPercentFactor { get; init; }
}