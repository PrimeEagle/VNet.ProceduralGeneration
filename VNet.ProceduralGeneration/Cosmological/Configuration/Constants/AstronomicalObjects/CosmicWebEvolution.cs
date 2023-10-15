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
                private static readonly InterpolationAlgorithmArgs _interpolationAlgorithmArgs = new();

                private static readonly PerlinNoiseAlgorithmArgs _noiseAlgorithmArgs = new()
                {
                    Octave = 8
                };

                private static readonly PerlinNoiseAlgorithmArgs _tempAlgorithmArgs = new()
                {
                    Octave = 4
                };

                internal static double BaryonicFeedbackSpread { get; } = 0.5;
                internal static double BaryonicFeedbackStrength { get; } = 0.1;
                internal static double BaryonicFeedbackThreshold { get; } = 1.2;
                internal static double BaseCoolingRate { get; } = 0.01;
                internal static double BaseHeatingRate { get; } = 0.1;
                internal static double CollisionalCoolingFactor { get; } = 0.02;
                internal static double CollisionalHeatingFactor { get; } = 0.01;
                internal static double CoolingRateDensityFactor { get; } = 0.05;
                internal static double DensityThresholdForStructureIdentification { get; } = 0.5;
                internal static double DensityThresholdForVoidIdentification { get; } = 0.2;
                internal static double GalacticFeedbackEnergy { get; } = 1.0;
                internal static double GalacticFeedbackThreshold { get; } = 2.5;
                internal static double HeatingRateDensityFactor { get; } = 0.02;
                internal static double InitialHeliumPercentage { get; } = 25.0;
                internal static double InitialHydrogenPercentage { get; } = 75.0;
                internal static double InitialMetalPercentage { get; } = 0.0;
                internal static double InitialRadiationStrength { get; } = 2.0;
                internal static IInterpolationAlgorithm InterpolationAlgorithm { get; } = new LinearInterpolation(_interpolationAlgorithmArgs);
                internal static int MaxEffectiveRangeOfGravity { get; } = 1;
                internal static int MaxEffectiveRangeOfRadiation { get; } = 1;
                internal static int MergingRadius { get; } = 2;
                internal static double MergingThreshold { get; } = 2.0;
                internal static INoiseAlgorithm NoiseAlgorithm { get; } = new PerlinNoise(_noiseAlgorithmArgs);
                internal static double PercentGasConvertedToStars { get; } = 5.0;
                internal static double PercentOfStarMassConvertedToMetals { get; } = 2.0;
                internal static double PercentOfStarMassRetainedAsHydrogen { get; } = 98.0;
                internal static double RadiationDecayRate { get; } = 0.05;
                internal static double ShockHeatingMinimumDensityThreshold { get; } = 0.5;
                internal static double SigmaForStructureIdentification { get; } = 0.5;
                internal static double StarFormationMaximumTemperatureThreshold { get; } = 10.0;
                internal static double StellarFormationMinimumDensityThreshold { get; } = 1.5;
                internal static double TemperatureFluctuationRange { get; } = 0.05;
                internal static double TemperatureIncreaseDueToShockHeating { get; } = 10.0;
                internal static INoiseAlgorithm TemperatureNoiseAlgorithm { get; } = new PerlinNoise(_tempAlgorithmArgs);
                internal static double TimeStep { get; } = 1;
            }
        }
    }
}