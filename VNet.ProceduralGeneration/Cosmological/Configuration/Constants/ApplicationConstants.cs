using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Enum;
// ReSharper disable CheckNamespace

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

internal static partial class Constants
{
    internal static partial class Advanced
    {
        internal static class Application
        {
            internal static bool ApplyGravitationalEffectsDampenBaryonicMatter { get; } = true;
            internal static bool ApplyGravitationalEffectsPreventDarkMatterClumping { get; } = true;
            internal static bool ApplyGravitationalEffectsApplyDarkEnergy { get; } = true;
            internal static float BaryonicMatterDampeningFactor { get; } = 0.5f;
            internal static double ElectricalCurrentConversionFactor { get; } = 0d;
            internal static float InteriorObjectOverlapThreshold { get; } = 0.0005f;
            internal static double LengthConversionFactor { get; } = 0d;
            internal static float LuminosityConversionFactor { get; } = 0f;
            internal static double MassConversionFactor { get; } = 0d;
            internal static int MaxDegreesOfParallelismLevel1 { get; } = Environment.ProcessorCount;
            internal static int MaxDegreesOfParallelismLevel2 { get; } = Environment.ProcessorCount - 2 > 1 ? Environment.ProcessorCount - 2 : 1;
            internal static int MaxDegreesOfParallelismLevel3 { get; } = Environment.ProcessorCount - 4 > 1 ? Environment.ProcessorCount - 4 : 1;
            internal static int MaxDegreesOfParallelismLevel4 { get; } = Environment.ProcessorCount - 6 > 1 ? Environment.ProcessorCount - 6 : 1;
            internal static float MinimumDarkMatterDistanceToPreventClumping { get; } = 0.1f;
            internal static IRandomGenerationAlgorithm RandomGenerator { get; } = new DotNetGenerator();
            internal static SizeType SizeMeaning { get; } = SizeType.Diameter;
            internal static double TemperatureConversionFactor { get; } = 0d;
            internal static double TimeConversionFactor { get; } = 0d;
        }
    }
}