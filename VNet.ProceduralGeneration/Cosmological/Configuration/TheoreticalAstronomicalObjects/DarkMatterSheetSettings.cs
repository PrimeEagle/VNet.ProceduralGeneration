using System.ComponentModel;
using VNet.Configuration;
using VNet.Configuration.Attributes;


namespace VNet.ProceduralGeneration.Cosmological.Configuration.TheoreticalAstronomicalObjects;

public class DarkMatterSheetSettings : ISettings
{
    [DisplayName("Count Age Factor")]
    [Tooltip("Weighting factor for the age of the universe on dark matter sheet count. Higher value results in more sheets.")]
    public double CountAgeFactor { get; init; }

    [DisplayName("Count Baryonic Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter sheet count. Higher value results in more sheets.")]
    public double CountBaryonicMatterPercentFactor { get; init; }

    [DisplayName("Count Dark Energy Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark energy in the universe on dark matter sheet count. Higher value results in more sheets.")]
    public double CountDarkEnergyPercentFactor { get; init; }

    [DisplayName("Count Dark Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter sheet count. Higher value results in less sheets.")]
    public double CountDarkMatterPercentFactor { get; init; }

    [DisplayName("Count Mass Factor")]
    [Tooltip("Weighting factor for the age of the universe on dark matter sheet count. Higher value results in more sheets.")]
    public double CountMassFactor { get; init; }

    [DisplayName("Count Size Factor")]
    [Tooltip("Weighting factor for the size of the universe on dark matter sheet count. Higher value results in more sheets.")]
    public double CountSizeFactor { get; init; }

    public DarkMatterSheetSettings()
    {
        CountAgeFactor = Constants.Advanced.TheoreticalObjects.DarkMatterSheet.CountAgeFactor;
        CountMassFactor = Constants.Advanced.TheoreticalObjects.DarkMatterSheet.CountMassFactor;
        CountSizeFactor = Constants.Advanced.TheoreticalObjects.DarkMatterSheet.CountSizeFactor;
        CountBaryonicMatterPercentFactor = Constants.Advanced.TheoreticalObjects.DarkMatterSheet.CountBaryonicMatterPercentFactor;
        CountDarkMatterPercentFactor = Constants.Advanced.TheoreticalObjects.DarkMatterSheet.CountDarkMatterPercentFactor;
        CountDarkEnergyPercentFactor = Constants.Advanced.TheoreticalObjects.DarkMatterSheet.CountDarkEnergyPercentFactor;
    }
}