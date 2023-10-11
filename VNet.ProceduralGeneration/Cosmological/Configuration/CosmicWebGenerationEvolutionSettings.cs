using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;
using VNet.Scientific.Interpolation;
using VNet.Scientific.Noise;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class CosmicWebGenerationEvolutionSettings : ISettings
    {
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

        [DisplayName("")]
        [Tooltip("")]
        public double InitialRadiationStrength { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double RadiationDecayRate { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicFeedbackThreshold { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicFeedbackStrength { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicFeedbackSpread { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double TemperatureFluctuationRange { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaseCoolingRate { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaseHeatingRate { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double CoolingRateDensityFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double HeatingRateDensityFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double CollisionalCoolingFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double CollisionalHeatingFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double StellarFormationMinimumDensityThreshold { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        [Range(0, 100)]
        public double PercentGasConvertedToStars { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double MergingThreshold { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public int MergingRadius { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double GalacticFeedbackThreshold { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double GalacticFeedbackEnergy { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DensityThresholdForVoidIdentification { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DensityThresholdForStructureIdentification { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double SigmaForStructureIdentification { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(InitialHeliumPercentage), nameof(InitialMetalPercentage) })]
        public double InitialHydrogenPercentage { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(InitialHydrogenPercentage), nameof(InitialMetalPercentage) })]
        public double InitialHeliumPercentage { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(InitialHydrogenPercentage), nameof(InitialHeliumPercentage) })]
        public double InitialMetalPercentage { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double StarFormationMaximumTemperatureThreshold { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double ShockHeatingMinimumDensityThreshold { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double TimeStep { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double PercentOfStarMassConvertedToMetals { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double PercentOfStarMassRetainedAsHydrogen { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double TemperatureIncreaseDueToShockHeating { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public int MaxEffectiveRangeOfGravity { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public int MaxEffectiveRangeOfRadiation { get; set; }




        public CosmicWebGenerationEvolutionSettings()
        {
            this.NoiseAlgorithm = ConfigConstants.CosmicWebEvolution.NoiseAlgorithm;
            this.InterpolationAlgorithm = ConfigConstants.CosmicWebEvolution.InterpolationAlgorithm;
            this.TemperatureNoiseAlgorithm = ConfigConstants.CosmicWebEvolution.TemperatureNoiseAlgorithm;
            this.InitialRadiationStrength = ConfigConstants.CosmicWebEvolution.InitialRadiationStrength;
            this.RadiationDecayRate = ConfigConstants.CosmicWebEvolution.RadiationDecayRate;
            this.BaryonicFeedbackThreshold = ConfigConstants.CosmicWebEvolution.BaryonicFeedbackThreshold;
            this.BaryonicFeedbackStrength = ConfigConstants.CosmicWebEvolution.BaryonicFeedbackStrength;
            this.BaryonicFeedbackSpread = ConfigConstants.CosmicWebEvolution.BaryonicFeedbackSpread;
            this.TemperatureFluctuationRange = ConfigConstants.CosmicWebEvolution.TemperatureFluctuationRange;
            this.BaseCoolingRate = ConfigConstants.CosmicWebEvolution.BaseCoolingRate;
            this.BaseHeatingRate = ConfigConstants.CosmicWebEvolution.BaseHeatingRate;
            this.CoolingRateDensityFactor = ConfigConstants.CosmicWebEvolution.CoolingRateDensityFactor;
            this.HeatingRateDensityFactor = ConfigConstants.CosmicWebEvolution.HeatingRateDensityFactor;
            this.CollisionalCoolingFactor = ConfigConstants.CosmicWebEvolution.CollisionalCoolingFactor;
            this.CollisionalHeatingFactor = ConfigConstants.CosmicWebEvolution.CollisionalHeatingFactor;
            this.StellarFormationMinimumDensityThreshold = ConfigConstants.CosmicWebEvolution.StellarFormationMinimumDensityThreshold;
            this.PercentGasConvertedToStars = ConfigConstants.CosmicWebEvolution.PercentGasConvertedToStars;
            this.MergingThreshold = ConfigConstants.CosmicWebEvolution.MergingThreshold;
            this.MergingRadius = ConfigConstants.CosmicWebEvolution.MergingRadius;
            this.GalacticFeedbackThreshold = ConfigConstants.CosmicWebEvolution.GalacticFeedbackThreshold;
            this.GalacticFeedbackEnergy = ConfigConstants.CosmicWebEvolution.GalacticFeedbackEnergy;
            this.DensityThresholdForVoidIdentification = ConfigConstants.CosmicWebEvolution.DensityThresholdForVoidIdentification;
            this.DensityThresholdForStructureIdentification = ConfigConstants.CosmicWebEvolution.DensityThresholdForStructureIdentification;
            this.SigmaForStructureIdentification = ConfigConstants.CosmicWebEvolution.SigmaForStructureIdentification;
            this.InitialHydrogenPercentage = ConfigConstants.CosmicWebEvolution.InitialHydrogenPercentage;
            this.InitialHeliumPercentage = ConfigConstants.CosmicWebEvolution.InitialHeliumPercentage;
            this.InitialMetalPercentage = ConfigConstants.CosmicWebEvolution.InitialMetalPercentage;
            this.StarFormationMaximumTemperatureThreshold = ConfigConstants.CosmicWebEvolution.StarFormationMaximumTemperatureThreshold;
            this.ShockHeatingMinimumDensityThreshold = ConfigConstants.CosmicWebEvolution.ShockHeatingMinimumDensityThreshold;
            this.TimeStep = ConfigConstants.CosmicWebEvolution.TimeStep;
            this.PercentOfStarMassConvertedToMetals = ConfigConstants.CosmicWebEvolution.PercentOfStarMassConvertedToMetals;
            this.PercentOfStarMassRetainedAsHydrogen = ConfigConstants.CosmicWebEvolution.PercentOfStarMassRetainedAsHydrogen;
            this.TemperatureIncreaseDueToShockHeating = ConfigConstants.CosmicWebEvolution.TemperatureIncreaseDueToShockHeating;
            this.MaxEffectiveRangeOfGravity = ConfigConstants.CosmicWebEvolution.MaxEffectiveRangeOfGravity;
            this.MaxEffectiveRangeOfRadiation = ConfigConstants.CosmicWebEvolution.MaxEffectiveRangeOfRadiation;
        }
    }
}