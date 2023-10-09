using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;
using VNet.Scientific.Interpolation;
using VNet.Scientific.Noise;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class CosmicWebGenerationEvolutionSettings : ISettings
    {
        public INoiseAlgorithm NoiseAlgorithm { get; set; }
        public IInterpolationAlgorithm InterpolationAlgorithm { get; set; }
        public INoiseAlgorithm TemperatureNoiseAlgorithm { get; set; }
        public double InitialRadiationStrength { get; set; }
        public double RadiationDecayRate { get; set; }
        public double BaryonicFeedbackThreshold { get; set; }
        public double BaryonicFeedbackStrength { get; set; }
        public double BaryonicFeedbackSpread { get; set; }
        public double TemperatureFluctuationRange { get; set; }
        public double BaseCoolingRate { get; set; }
        public double BaseHeatingRate { get; set; }
        public double CoolingRateDensityFactor { get; set; }
        public double HeatingRateDensityFactor { get; set; }
        public double CollisionalCoolingFactor { get; set; }
        public double CollisionalHeatingFactor { get; set; }
        public double StellarFormationMinimumDensityThreshold { get; set; }
        public double PercentGasConvertedToStars { get; set; }
        public double MergingThreshold { get; set; }
        public int MergingRadius { get; set; }
        public double GalacticFeedbackThreshold { get; set; }
        public double GalacticFeedbackEnergy { get; set; }
        public double DensityThresholdForVoidIdentification { get; set; }
        public double DensityThresholdForStructureIdentification { get; set; }
        public double SigmaForStructureIdentification { get; set; }
        public double InitialHydrogenPercentage { get; set; }
        public double InitialHeliumPercentage { get; set; }
        public double InitialMetalPercentage { get; set; }
        public double StarFormationMaximumTemperatureThreshold { get; set; }
        public double ShockHeatingMinimumDensityThreshold { get; set; }
        public double TimeStep { get; set; }
        public double PercentOfStarMassConvertedToMetals { get; set; }
        public double PercentOfStarMassRetainedAsHydrogen { get; set; }
        public double TemperatureIncreaseDueToShockHeating { get; set; }
        public int MaxEffectiveRangeOfGravity { get; set; }
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