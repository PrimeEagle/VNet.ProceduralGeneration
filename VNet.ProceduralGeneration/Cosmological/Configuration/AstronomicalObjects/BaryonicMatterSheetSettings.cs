using System.ComponentModel;
using VNet.Configuration;
using VNet.Configuration.Attributes;


namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

public class BaryonicMatterSheetSettings : ISettings
{
    [DisplayName("Count Age Factor")]
    [Tooltip("Weighting factor for the age of the universe on baryonic matter (normal matter) sheet count. Higher value results in more sheets.")]
    public double CountAgeFactor { get; init; }

    [DisplayName("Count Baryonic Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of baryonic matter (normal matter) in the universe on baryonic matter (normal matter) sheet count. Higher value results in less sheets.")]
    public double CountBaryonicMatterPercentFactor { get; init; }

    [DisplayName("Count Dark Energy Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark energy in the universe on baryonic matter (normal matter) sheet count. Higher value results in more sheets.")]
    public double CountDarkEnergyPercentFactor { get; init; }

    [DisplayName("Count Dark Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark matter in the universe on baryonic matter (normal matter) sheet count. Higher value results in less sheets.")]
    public double CountDarkMatterPercentFactor { get; init; }

    [DisplayName("Count Mass Factor")]
    [Tooltip("Weighting factor for the mass of the universe on baryonic matter (normal matter) sheet count. Higher value results in more sheets.")]
    public double CountMassFactor { get; init; }

    [DisplayName("Count Size Factor")]
    [Tooltip("Weighting factor for the size of the universe on baryonic matter (normal matter) sheet count. Higher value results in more sheets.")]
    public double CountSizeFactor { get; init; }

    public BaryonicMatterSheetSettings()
    {
        CountAgeFactor = Constants.Advanced.Objects.BaryonicMatterSheet.CountAgeFactor;
        CountMassFactor = Constants.Advanced.Objects.BaryonicMatterSheet.CountMassFactor;
        CountSizeFactor = Constants.Advanced.Objects.BaryonicMatterSheet.CountSizeFactor;
        CountBaryonicMatterPercentFactor = Constants.Advanced.Objects.BaryonicMatterSheet.CountBaryonicMatterPercentFactor;
        CountDarkMatterPercentFactor = Constants.Advanced.Objects.BaryonicMatterSheet.CountDarkMatterPercentFactor;
        CountDarkEnergyPercentFactor = Constants.Advanced.Objects.BaryonicMatterSheet.CountDarkEnergyPercentFactor;
    }
}