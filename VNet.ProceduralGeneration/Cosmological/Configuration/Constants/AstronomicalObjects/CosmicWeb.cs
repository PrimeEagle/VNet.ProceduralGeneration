// ReSharper disable CheckNamespace

using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;
using VNet.Scientific.Interpolation;
using VNet.Scientific.Noise;
using VNet.Scientific.Noise.Other;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;


internal static partial class Constants
{
    internal static partial class Advanced
    {
        internal static partial class Objects
        {
            internal static partial class CosmicWeb
            {
                internal static Range<float> CosmicMicrowaveBackgroundRange { get; } = new(2.0f, 3.0f);
                internal static float DensityThresholdForStructureIdentification { get; } = 0.5f;
                internal static float DensityThresholdForVoidIdentification { get; } = 0.2f;
                internal static float EvolutionBaryonicFeedbackSpread { get; } = 1.2f;
                internal static float EvolutionBaryonicFeedbackStrength { get; } = 0.1f;
                internal static float EvolutionBaryonicFeedbackThreshold { get; } = 0.5f;
                internal static float EvolutionBaseCoolingRate { get; } = 0.01f;
                internal static float EvolutionBaseHeatingRate { get; } = 0.1f;
                internal static float EvolutionCollisionalCoolingFactor { get; } = 0.02f;
                internal static float EvolutionCollisionalHeatingFactor { get; } = 0.01f;
                internal static float EvolutionCoolingRateDensityFactor { get; } = 0.05f;
                internal static float EvolutionGalacticFeedbackEnergy { get; } = 1.0f;
                internal static float EvolutionGalacticFeedbackThreshold { get; } = 2.5f;
                internal static float EvolutionHeatingRateDensityFactor { get; } = 0.02f;
                internal static float EvolutionInitialHeliumPercentage { get; } = 25.0f;
                internal static float EvolutionInitialHydrogenPercentage { get; } = 75.0f;
                internal static float EvolutionInitialMetalPercentage { get; } = 0.0f;
                internal static float EvolutionInitialRadiationStrength { get; } = 2.0f;
                internal static IInterpolationAlgorithm EvolutionInterpolationAlgorithm { get; } = new LinearInterpolation(new InterpolationAlgorithmArgs());
                internal static int EvolutionMaxEffectiveRangeOfGravity { get; } = 1;
                internal static int EvolutionMaxEffectiveRangeOfRadiation { get; } = 1;
                internal static int EvolutionMergingRadius { get; } = 2;
                internal static float EvolutionMergingThreshold { get; } = 2.0f;
                internal static INoiseAlgorithm EvolutionNoiseAlgorithm { get; } = new PerlinNoise(new PerlinNoiseAlgorithmArgs());
                internal static float EvolutionPercentGasConvertedToStars { get; } = 5.0f;
                internal static float EvolutionPercentOfStarMassConvertedToMetals { get; } = 2.0f;
                internal static float EvolutionPercentOfStarMassRetainedAsHydrogen { get; } = 98.0f;
                internal static float EvolutionRadiationDecayRate { get; } = 0.05f;
                internal static float EvolutionShockHeatingMinimumDensityThreshold { get; } = 0.5f;
                internal static float EvolutionStarFormationMaximumTemperatureThreshold { get; } = 10.0f;
                internal static float EvolutionStellarFormationMinimumDensityThreshold { get; } = 1.5f;
                internal static float EvolutionTemperatureFluctuationRange { get; } = 0.05f;
                internal static float EvolutionTemperatureIncreaseDueToShockHeating { get; } = 10.0f;
                internal static INoiseAlgorithm EvolutionTemperatureNoiseAlgorithm { get; } = new PerlinNoise(new PerlinNoiseAlgorithmArgs());
                internal static float EvolutionTimeStep { get; } = 1.0f;
                internal static float GravitationalHeatingEfficiencyPercent { get; } = 10.0f;
                internal static int HeightmapGaussianKernelSize { get; } = 3;
                internal static float HeightmapGaussianSigma { get; } = 1.0f;
                internal static int ParallelismLevel { get; } = 0;
                internal static IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; } = new DotNetGenerator();
                internal static float SigmaForStructureIdentification { get; } = 1.0f;
            }
        }
    }
}