using System.ComponentModel;
using VNet.Configuration;
using VNet.Configuration.Attributes;


namespace VNet.ProceduralGeneration.Cosmological.Configuration.TheoreticalAstronomicalObjects;

public class DarkMatterFilamentSettings : ISettings
{
    [DisplayName("Count Age Factor")]
    [Tooltip("Weighting factor for the age of the universe on dark matter filament count. Higher value results in more filaments.")]
    public double CountAgeFactor { get; init; }

    [DisplayName("Count Baryonic Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter filament count. Higher value results in more filaments.")]
    public double CountBaryonicMatterPercentFactor { get; init; }

    [DisplayName("Count Dark Energy Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark energy in the universe on dark matter filament count. Higher value results in more filaments.")]
    public double CountDarkEnergyPercentFactor { get; init; }

    [DisplayName("Count Dark Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter filament count. Higher value results in less filaments.")]
    public double CountDarkMatterPercentFactor { get; init; }

    [DisplayName("Count Mass Factor")]
    [Tooltip("Weighting factor for the age of the universe on dark matter filament count. Higher value results in more filaments.")]
    public double CountMassFactor { get; init; }

    [DisplayName("Count Size Factor")]
    [Tooltip("Weighting factor for the size of the universe on dark matter filament count. Higher value results in more filaments.")]
    public double CountSizeFactor { get; init; }

    public DarkMatterFilamentSettings()
    {
        CountAgeFactor = Constants.Advanced.TheoreticalObjects.DarkMatterFilament.CountAgeFactor;
        CountMassFactor = Constants.Advanced.TheoreticalObjects.DarkMatterFilament.CountMassFactor;
        CountSizeFactor = Constants.Advanced.TheoreticalObjects.DarkMatterFilament.CountSizeFactor;
        CountBaryonicMatterPercentFactor = Constants.Advanced.TheoreticalObjects.DarkMatterFilament.CountBaryonicMatterPercentFactor;
        CountDarkMatterPercentFactor = Constants.Advanced.TheoreticalObjects.DarkMatterFilament.CountDarkMatterPercentFactor;
        CountDarkEnergyPercentFactor = Constants.Advanced.TheoreticalObjects.DarkMatterFilament.CountDarkEnergyPercentFactor;
    }
}