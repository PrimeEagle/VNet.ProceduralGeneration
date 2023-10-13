using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;
using VNet.Scientific.Interpolation;
using VNet.Scientific.Noise;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class CosmicWebGenerationEvolutionSettings : ISettings
{
    public CosmicWebGenerationEvolutionSettings()
    {
        NoiseAlgorithm = ConfigConstants.CosmicWebEvolution.NoiseAlgorithm;
        InterpolationAlgorithm = ConfigConstants.CosmicWebEvolution.InterpolationAlgorithm;
        TemperatureNoiseAlgorithm = ConfigConstants.CosmicWebEvolution.TemperatureNoiseAlgorithm;
        InitialRadiationStrength = ConfigConstants.CosmicWebEvolution.InitialRadiationStrength;
        RadiationDecayRate = ConfigConstants.CosmicWebEvolution.RadiationDecayRate;
        BaryonicFeedbackThreshold = ConfigConstants.CosmicWebEvolution.BaryonicFeedbackThreshold;
        BaryonicFeedbackStrength = ConfigConstants.CosmicWebEvolution.BaryonicFeedbackStrength;
        BaryonicFeedbackSpread = ConfigConstants.CosmicWebEvolution.BaryonicFeedbackSpread;
        TemperatureFluctuationRange = ConfigConstants.CosmicWebEvolution.TemperatureFluctuationRange;
        BaseCoolingRate = ConfigConstants.CosmicWebEvolution.BaseCoolingRate;
        BaseHeatingRate = ConfigConstants.CosmicWebEvolution.BaseHeatingRate;
        CoolingRateDensityFactor = ConfigConstants.CosmicWebEvolution.CoolingRateDensityFactor;
        HeatingRateDensityFactor = ConfigConstants.CosmicWebEvolution.HeatingRateDensityFactor;
        CollisionalCoolingFactor = ConfigConstants.CosmicWebEvolution.CollisionalCoolingFactor;
        CollisionalHeatingFactor = ConfigConstants.CosmicWebEvolution.CollisionalHeatingFactor;
        StellarFormationMinimumDensityThreshold = ConfigConstants.CosmicWebEvolution.StellarFormationMinimumDensityThreshold;
        PercentGasConvertedToStars = ConfigConstants.CosmicWebEvolution.PercentGasConvertedToStars;
        MergingThreshold = ConfigConstants.CosmicWebEvolution.MergingThreshold;
        MergingRadius = ConfigConstants.CosmicWebEvolution.MergingRadius;
        GalacticFeedbackThreshold = ConfigConstants.CosmicWebEvolution.GalacticFeedbackThreshold;
        GalacticFeedbackEnergy = ConfigConstants.CosmicWebEvolution.GalacticFeedbackEnergy;
        DensityThresholdForVoidIdentification = ConfigConstants.CosmicWebEvolution.DensityThresholdForVoidIdentification;
        DensityThresholdForStructureIdentification = ConfigConstants.CosmicWebEvolution.DensityThresholdForStructureIdentification;
        SigmaForStructureIdentification = ConfigConstants.CosmicWebEvolution.SigmaForStructureIdentification;
        InitialHydrogenPercentage = ConfigConstants.CosmicWebEvolution.InitialHydrogenPercentage;
        InitialHeliumPercentage = ConfigConstants.CosmicWebEvolution.InitialHeliumPercentage;
        InitialMetalPercentage = ConfigConstants.CosmicWebEvolution.InitialMetalPercentage;
        StarFormationMaximumTemperatureThreshold = ConfigConstants.CosmicWebEvolution.StarFormationMaximumTemperatureThreshold;
        ShockHeatingMinimumDensityThreshold = ConfigConstants.CosmicWebEvolution.ShockHeatingMinimumDensityThreshold;
        TimeStep = ConfigConstants.CosmicWebEvolution.TimeStep;
        PercentOfStarMassConvertedToMetals = ConfigConstants.CosmicWebEvolution.PercentOfStarMassConvertedToMetals;
        PercentOfStarMassRetainedAsHydrogen = ConfigConstants.CosmicWebEvolution.PercentOfStarMassRetainedAsHydrogen;
        TemperatureIncreaseDueToShockHeating = ConfigConstants.CosmicWebEvolution.TemperatureIncreaseDueToShockHeating;
        MaxEffectiveRangeOfGravity = ConfigConstants.CosmicWebEvolution.MaxEffectiveRangeOfGravity;
        MaxEffectiveRangeOfRadiation = ConfigConstants.CosmicWebEvolution.MaxEffectiveRangeOfRadiation;
    }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public INoiseAlgorithm NoiseAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IInterpolationAlgorithm InterpolationAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public INoiseAlgorithm TemperatureNoiseAlgorithm { get; set; }

    [DisplayName("")] [Tooltip("")] public double InitialRadiationStrength { get; set; }

    [DisplayName("")] [Tooltip("")] public double RadiationDecayRate { get; set; }

    [DisplayName("")] [Tooltip("")] public double BaryonicFeedbackThreshold { get; set; }

    [DisplayName("")] [Tooltip("")] public double BaryonicFeedbackStrength { get; set; }

    [DisplayName("")] [Tooltip("")] public double BaryonicFeedbackSpread { get; set; }

    [DisplayName("")] [Tooltip("")] public double TemperatureFluctuationRange { get; set; }

    [DisplayName("")] [Tooltip("")] public double BaseCoolingRate { get; set; }

    [DisplayName("")] [Tooltip("")] public double BaseHeatingRate { get; set; }

    [DisplayName("")] [Tooltip("")] public double CoolingRateDensityFactor { get; set; }

    [DisplayName("")] [Tooltip("")] public double HeatingRateDensityFactor { get; set; }

    [DisplayName("")] [Tooltip("")] public double CollisionalCoolingFactor { get; set; }

    [DisplayName("")] [Tooltip("")] public double CollisionalHeatingFactor { get; set; }

    [DisplayName("")] [Tooltip("")] public double StellarFormationMinimumDensityThreshold { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    [Range(0, 100)]
    public double PercentGasConvertedToStars { get; set; }

    [DisplayName("")] [Tooltip("")] public double MergingThreshold { get; set; }

    [DisplayName("")] [Tooltip("")] public int MergingRadius { get; set; }

    [DisplayName("")] [Tooltip("")] public double GalacticFeedbackThreshold { get; set; }

    [DisplayName("")] [Tooltip("")] public double GalacticFeedbackEnergy { get; set; }

    [DisplayName("")] [Tooltip("")] public double DensityThresholdForVoidIdentification { get; set; }

    [DisplayName("")] [Tooltip("")] public double DensityThresholdForStructureIdentification { get; set; }

    [DisplayName("")] [Tooltip("")] public double SigmaForStructureIdentification { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    [Range(0, 100)]
    [PercentageWithProperties(new[] {nameof(InitialHeliumPercentage), nameof(InitialMetalPercentage)})]
    public double InitialHydrogenPercentage { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    [Range(0, 100)]
    [PercentageWithProperties(new[] {nameof(InitialHydrogenPercentage), nameof(InitialMetalPercentage)})]
    public double InitialHeliumPercentage { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    [Range(0, 100)]
    [PercentageWithProperties(new[] {nameof(InitialHydrogenPercentage), nameof(InitialHeliumPercentage)})]
    public double InitialMetalPercentage { get; set; }

    [DisplayName("")] [Tooltip("")] public double StarFormationMaximumTemperatureThreshold { get; set; }

    [DisplayName("")] [Tooltip("")] public double ShockHeatingMinimumDensityThreshold { get; set; }

    [DisplayName("")] [Tooltip("")] public double TimeStep { get; set; }

    [DisplayName("")] [Tooltip("")] public double PercentOfStarMassConvertedToMetals { get; set; }

    [DisplayName("")] [Tooltip("")] public double PercentOfStarMassRetainedAsHydrogen { get; set; }

    [DisplayName("")] [Tooltip("")] public double TemperatureIncreaseDueToShockHeating { get; set; }

    [DisplayName("")] [Tooltip("")] public int MaxEffectiveRangeOfGravity { get; set; }

    [DisplayName("")] [Tooltip("")] public int MaxEffectiveRangeOfRadiation { get; set; }
}