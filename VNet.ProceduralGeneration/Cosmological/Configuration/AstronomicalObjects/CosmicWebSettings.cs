using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Configuration.Attributes.Validation;
using VNet.Mathematics.Randomization.Generation;
using VNet.Scientific.Interpolation;
using VNet.Scientific.Noise;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

public class CosmicWebSettings : ISettings
{
    [Range(1, 99)]
    [DisplayName("Heightmap Gaussian Kernel Size")]
    [Tooltip("This value creates an n x n grid and, for each pixel, looks at other pixels contained in the grid to determine the amount of blur to apply.")]
    public int HeightmapGaussianKernelSize { get; init; }

    [Range(0, float.MaxValue)]
    [DisplayName("Heightmap Gaussian Sigma")]
    [Tooltip("The amount of gaussian blur to apply to the Heightmap Image File (0 = none).")]
    public float HeightmapGaussianSigma { get; init; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionBaryonicFeedbackSpread { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionBaryonicFeedbackStrength { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionBaryonicFeedbackThreshold { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionBaseCoolingRate { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionBaseHeatingRate { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionCollisionalCoolingFactor { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionCollisionalHeatingFactor { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionCoolingRateDensityFactor { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionDensityThresholdForStructureIdentification { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionDensityThresholdForVoidIdentification { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionGalacticFeedbackEnergy { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionGalacticFeedbackThreshold { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionHeatingRateDensityFactor { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    [Range(0, 100)]
    [PercentageWithProperties(new[] { nameof(EvolutionInitialHydrogenPercentage), nameof(EvolutionInitialMetalPercentage) })]
    public double EvolutionInitialHeliumPercentage { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    [Range(0, 100)]
    [PercentageWithProperties(new[] { nameof(EvolutionInitialHeliumPercentage), nameof(EvolutionInitialMetalPercentage) })]
    public double EvolutionInitialHydrogenPercentage { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    [Range(0, 100)]
    [PercentageWithProperties(new[] { nameof(EvolutionInitialHydrogenPercentage), nameof(EvolutionInitialHeliumPercentage) })]
    public double EvolutionInitialMetalPercentage { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionInitialRadiationStrength { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IInterpolationAlgorithm EvolutionInterpolationAlgorithm { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public int EvolutionMaxEffectiveRangeOfGravity { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public int EvolutionMaxEffectiveRangeOfRadiation { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public int EvolutionMergingRadius { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionMergingThreshold { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public INoiseAlgorithm EvolutionNoiseAlgorithm { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    [Range(0, 100)]
    public double EvolutionPercentGasConvertedToStars { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionPercentOfStarMassConvertedToMetals { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionPercentOfStarMassRetainedAsHydrogen { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionRadiationDecayRate { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionShockHeatingMinimumDensityThreshold { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double SigmaForStructureIdentification { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionStarFormationMaximumTemperatureThreshold { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionStellarFormationMinimumDensityThreshold { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionTemperatureFluctuationRange { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionTemperatureIncreaseDueToShockHeating { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public INoiseAlgorithm EvolutionTemperatureNoiseAlgorithm { get; set; }

    [DisplayName("")]
    [Tooltip("")]
    public double EvolutionTimeStep { get; set; }

    [Required]
    [DisplayName("Random Generation Algorithm")]
    [Tooltip("The algorithm used during object generation to generate random values.")]
    public IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; init; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public VNet.Configuration.Range<float> CosmicMicrowaveBackgroundRange { get; set; }

    [Range(0, 1)]
    [DisplayName("Gravitational Heating Efficiency Percent")]
    [Tooltip("")]
    public float GravitationalHeatingEfficiencyPercent { get; set; }




    public CosmicWebSettings()
    {
        HeightmapGaussianKernelSize = Constants.Advanced.Objects.CosmicWeb.HeightmapGaussianKernelSize;
        HeightmapGaussianSigma = Constants.Advanced.Objects.CosmicWeb.HeightmapGaussianSigma;
        EvolutionNoiseAlgorithm = Constants.Advanced.Objects.CosmicWeb.EvolutionNoiseAlgorithm;
        EvolutionInterpolationAlgorithm = Constants.Advanced.Objects.CosmicWeb.EvolutionInterpolationAlgorithm;
        EvolutionTemperatureNoiseAlgorithm = Constants.Advanced.Objects.CosmicWeb.EvolutionTemperatureNoiseAlgorithm;
        EvolutionInitialRadiationStrength = Constants.Advanced.Objects.CosmicWeb.EvolutionInitialRadiationStrength;
        EvolutionRadiationDecayRate = Constants.Advanced.Objects.CosmicWeb.EvolutionRadiationDecayRate;
        EvolutionBaryonicFeedbackThreshold = Constants.Advanced.Objects.CosmicWeb.EvolutionBaryonicFeedbackThreshold;
        EvolutionBaryonicFeedbackStrength = Constants.Advanced.Objects.CosmicWeb.EvolutionBaryonicFeedbackStrength;
        EvolutionBaryonicFeedbackSpread = Constants.Advanced.Objects.CosmicWeb.EvolutionBaryonicFeedbackSpread;
        EvolutionTemperatureFluctuationRange = Constants.Advanced.Objects.CosmicWeb.EvolutionTemperatureFluctuationRange;
        EvolutionBaseCoolingRate = Constants.Advanced.Objects.CosmicWeb.EvolutionBaseCoolingRate;
        EvolutionBaseHeatingRate = Constants.Advanced.Objects.CosmicWeb.EvolutionBaseHeatingRate;
        EvolutionCoolingRateDensityFactor = Constants.Advanced.Objects.CosmicWeb.EvolutionCoolingRateDensityFactor;
        EvolutionHeatingRateDensityFactor = Constants.Advanced.Objects.CosmicWeb.EvolutionHeatingRateDensityFactor;
        EvolutionCollisionalCoolingFactor = Constants.Advanced.Objects.CosmicWeb.EvolutionCollisionalCoolingFactor;
        EvolutionCollisionalHeatingFactor = Constants.Advanced.Objects.CosmicWeb.EvolutionCollisionalHeatingFactor;
        EvolutionStellarFormationMinimumDensityThreshold = Constants.Advanced.Objects.CosmicWeb.EvolutionStellarFormationMinimumDensityThreshold;
        EvolutionPercentGasConvertedToStars = Constants.Advanced.Objects.CosmicWeb.EvolutionPercentGasConvertedToStars;
        EvolutionMergingThreshold = Constants.Advanced.Objects.CosmicWeb.EvolutionMergingThreshold;
        EvolutionMergingRadius = Constants.Advanced.Objects.CosmicWeb.EvolutionMergingRadius;
        EvolutionGalacticFeedbackThreshold = Constants.Advanced.Objects.CosmicWeb.EvolutionGalacticFeedbackThreshold;
        EvolutionGalacticFeedbackEnergy = Constants.Advanced.Objects.CosmicWeb.EvolutionGalacticFeedbackEnergy;
        EvolutionDensityThresholdForVoidIdentification = Constants.Advanced.Objects.CosmicWeb.DensityThresholdForVoidIdentification;
        EvolutionDensityThresholdForStructureIdentification = Constants.Advanced.Objects.CosmicWeb.DensityThresholdForStructureIdentification;
        SigmaForStructureIdentification = Constants.Advanced.Objects.CosmicWeb.SigmaForStructureIdentification;
        EvolutionInitialHydrogenPercentage = Constants.Advanced.Objects.CosmicWeb.EvolutionInitialHydrogenPercentage;
        EvolutionInitialHeliumPercentage = Constants.Advanced.Objects.CosmicWeb.EvolutionInitialHeliumPercentage;
        EvolutionInitialMetalPercentage = Constants.Advanced.Objects.CosmicWeb.EvolutionInitialMetalPercentage;
        EvolutionStarFormationMaximumTemperatureThreshold = Constants.Advanced.Objects.CosmicWeb.EvolutionStarFormationMaximumTemperatureThreshold;
        EvolutionShockHeatingMinimumDensityThreshold = Constants.Advanced.Objects.CosmicWeb.EvolutionShockHeatingMinimumDensityThreshold;
        EvolutionTimeStep = Constants.Advanced.Objects.CosmicWeb.EvolutionTimeStep;
        EvolutionPercentOfStarMassConvertedToMetals = Constants.Advanced.Objects.CosmicWeb.EvolutionPercentOfStarMassConvertedToMetals;
        EvolutionPercentOfStarMassRetainedAsHydrogen = Constants.Advanced.Objects.CosmicWeb.EvolutionPercentOfStarMassRetainedAsHydrogen;
        EvolutionTemperatureIncreaseDueToShockHeating = Constants.Advanced.Objects.CosmicWeb.EvolutionTemperatureIncreaseDueToShockHeating;
        EvolutionMaxEffectiveRangeOfGravity = Constants.Advanced.Objects.CosmicWeb.EvolutionMaxEffectiveRangeOfGravity;
        EvolutionMaxEffectiveRangeOfRadiation = Constants.Advanced.Objects.CosmicWeb.EvolutionMaxEffectiveRangeOfRadiation;
        RandomGenerationAlgorithm = Constants.Advanced.Objects.CosmicWeb.RandomGenerationAlgorithm;
        CosmicMicrowaveBackgroundRange = Constants.Advanced.Objects.CosmicWeb.CosmicMicrowaveBackgroundRange;
        GravitationalHeatingEfficiencyPercent = Constants.Advanced.Objects.CosmicWeb.GravitationalHeatingEfficiencyPercent;
    }
}