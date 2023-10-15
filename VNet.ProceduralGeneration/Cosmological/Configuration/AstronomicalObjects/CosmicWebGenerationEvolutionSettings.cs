using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Configuration.Attributes.Validation;
using VNet.Scientific.Interpolation;
using VNet.Scientific.Noise;


namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;


public class CosmicWebGenerationEvolutionSettings : ISettings
{
    [DisplayName("")][Tooltip("")] public double BaryonicFeedbackSpread { get; set; }

    [DisplayName("")][Tooltip("")] public double BaryonicFeedbackStrength { get; set; }

    [DisplayName("")][Tooltip("")] public double BaryonicFeedbackThreshold { get; set; }

    [DisplayName("")][Tooltip("")] public double BaseCoolingRate { get; set; }

    [DisplayName("")][Tooltip("")] public double BaseHeatingRate { get; set; }

    [DisplayName("")][Tooltip("")] public double CollisionalCoolingFactor { get; set; }

    [DisplayName("")][Tooltip("")] public double CollisionalHeatingFactor { get; set; }

    [DisplayName("")][Tooltip("")] public double CoolingRateDensityFactor { get; set; }

    [DisplayName("")][Tooltip("")] public double DensityThresholdForStructureIdentification { get; set; }

    [DisplayName("")][Tooltip("")] public double DensityThresholdForVoidIdentification { get; set; }

    [DisplayName("")][Tooltip("")] public double GalacticFeedbackEnergy { get; set; }

    [DisplayName("")][Tooltip("")] public double GalacticFeedbackThreshold { get; set; }

    [DisplayName("")][Tooltip("")] public double HeatingRateDensityFactor { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    [Range(0, 100)]
    [PercentageWithProperties(new[] { nameof(InitialHydrogenPercentage), nameof(InitialMetalPercentage) })]
    public double InitialHeliumPercentage { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    [Range(0, 100)]
    [PercentageWithProperties(new[] { nameof(InitialHeliumPercentage), nameof(InitialMetalPercentage) })]
    public double InitialHydrogenPercentage { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    [Range(0, 100)]
    [PercentageWithProperties(new[] { nameof(InitialHydrogenPercentage), nameof(InitialHeliumPercentage) })]
    public double InitialMetalPercentage { get; set; }

    [DisplayName("")][Tooltip("")] public double InitialRadiationStrength { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IInterpolationAlgorithm InterpolationAlgorithm { get; set; }

    [DisplayName("")][Tooltip("")] public int MaxEffectiveRangeOfGravity { get; set; }

    [DisplayName("")][Tooltip("")] public int MaxEffectiveRangeOfRadiation { get; set; }

    [DisplayName("")][Tooltip("")] public int MergingRadius { get; set; }

    [DisplayName("")][Tooltip("")] public double MergingThreshold { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public INoiseAlgorithm NoiseAlgorithm { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    [Range(0, 100)]
    public double PercentGasConvertedToStars { get; set; }

    [DisplayName("")][Tooltip("")] public double PercentOfStarMassConvertedToMetals { get; set; }

    [DisplayName("")][Tooltip("")] public double PercentOfStarMassRetainedAsHydrogen { get; set; }

    [DisplayName("")][Tooltip("")] public double RadiationDecayRate { get; set; }

    [DisplayName("")][Tooltip("")] public double ShockHeatingMinimumDensityThreshold { get; set; }

    [DisplayName("")][Tooltip("")] public double SigmaForStructureIdentification { get; set; }

    [DisplayName("")][Tooltip("")] public double StarFormationMaximumTemperatureThreshold { get; set; }

    [DisplayName("")][Tooltip("")] public double StellarFormationMinimumDensityThreshold { get; set; }

    [DisplayName("")][Tooltip("")] public double TemperatureFluctuationRange { get; set; }

    [DisplayName("")][Tooltip("")] public double TemperatureIncreaseDueToShockHeating { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public INoiseAlgorithm TemperatureNoiseAlgorithm { get; set; }

    [DisplayName("")][Tooltip("")] public double TimeStep { get; set; }

    public CosmicWebGenerationEvolutionSettings()
    {
        NoiseAlgorithm = Constants.Advanced.Objects.CosmicWeb.NoiseAlgorithm;
        InterpolationAlgorithm = Constants.Advanced.Objects.CosmicWeb.InterpolationAlgorithm;
        TemperatureNoiseAlgorithm = Constants.Advanced.Objects.CosmicWeb.TemperatureNoiseAlgorithm;
        InitialRadiationStrength = Constants.Advanced.Objects.CosmicWeb.InitialRadiationStrength;
        RadiationDecayRate = Constants.Advanced.Objects.CosmicWeb.RadiationDecayRate;
        BaryonicFeedbackThreshold = Constants.Advanced.Objects.CosmicWeb.BaryonicFeedbackThreshold;
        BaryonicFeedbackStrength = Constants.Advanced.Objects.CosmicWeb.BaryonicFeedbackStrength;
        BaryonicFeedbackSpread = Constants.Advanced.Objects.CosmicWeb.BaryonicFeedbackSpread;
        TemperatureFluctuationRange = Constants.Advanced.Objects.CosmicWeb.TemperatureFluctuationRange;
        BaseCoolingRate = Constants.Advanced.Objects.CosmicWeb.BaseCoolingRate;
        BaseHeatingRate = Constants.Advanced.Objects.CosmicWeb.BaseHeatingRate;
        CoolingRateDensityFactor = Constants.Advanced.Objects.CosmicWeb.CoolingRateDensityFactor;
        HeatingRateDensityFactor = Constants.Advanced.Objects.CosmicWeb.HeatingRateDensityFactor;
        CollisionalCoolingFactor = Constants.Advanced.Objects.CosmicWeb.CollisionalCoolingFactor;
        CollisionalHeatingFactor = Constants.Advanced.Objects.CosmicWeb.CollisionalHeatingFactor;
        StellarFormationMinimumDensityThreshold = Constants.Advanced.Objects.CosmicWeb.StellarFormationMinimumDensityThreshold;
        PercentGasConvertedToStars = Constants.Advanced.Objects.CosmicWeb.PercentGasConvertedToStars;
        MergingThreshold = Constants.Advanced.Objects.CosmicWeb.MergingThreshold;
        MergingRadius = Constants.Advanced.Objects.CosmicWeb.MergingRadius;
        GalacticFeedbackThreshold = Constants.Advanced.Objects.CosmicWeb.GalacticFeedbackThreshold;
        GalacticFeedbackEnergy = Constants.Advanced.Objects.CosmicWeb.GalacticFeedbackEnergy;
        DensityThresholdForVoidIdentification = Constants.Advanced.Objects.CosmicWeb.DensityThresholdForVoidIdentification;
        DensityThresholdForStructureIdentification = Constants.Advanced.Objects.CosmicWeb.DensityThresholdForStructureIdentification;
        SigmaForStructureIdentification = Constants.Advanced.Objects.CosmicWeb.SigmaForStructureIdentification;
        InitialHydrogenPercentage = Constants.Advanced.Objects.CosmicWeb.InitialHydrogenPercentage;
        InitialHeliumPercentage = Constants.Advanced.Objects.CosmicWeb.InitialHeliumPercentage;
        InitialMetalPercentage = Constants.Advanced.Objects.CosmicWeb.InitialMetalPercentage;
        StarFormationMaximumTemperatureThreshold = Constants.Advanced.Objects.CosmicWeb.StarFormationMaximumTemperatureThreshold;
        ShockHeatingMinimumDensityThreshold = Constants.Advanced.Objects.CosmicWeb.ShockHeatingMinimumDensityThreshold;
        TimeStep = Constants.Advanced.Objects.CosmicWeb.TimeStep;
        PercentOfStarMassConvertedToMetals = Constants.Advanced.Objects.CosmicWeb.PercentOfStarMassConvertedToMetals;
        PercentOfStarMassRetainedAsHydrogen = Constants.Advanced.Objects.CosmicWeb.PercentOfStarMassRetainedAsHydrogen;
        TemperatureIncreaseDueToShockHeating = Constants.Advanced.Objects.CosmicWeb.TemperatureIncreaseDueToShockHeating;
        MaxEffectiveRangeOfGravity = Constants.Advanced.Objects.CosmicWeb.MaxEffectiveRangeOfGravity;
        MaxEffectiveRangeOfRadiation = Constants.Advanced.Objects.CosmicWeb.MaxEffectiveRangeOfRadiation;
    }
}