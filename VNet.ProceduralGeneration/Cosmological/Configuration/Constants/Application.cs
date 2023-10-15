using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

internal static partial class ConfigConstants
{
    internal static class Application
    {
        internal static int MaxDegreesOfParallelismLevel1 { get; } = Environment.ProcessorCount;
        internal static int MaxDegreesOfParallelismLevel2 { get; } = Environment.ProcessorCount - 2 > 1 ? Environment.ProcessorCount - 2 : 1;
        internal static int MaxDegreesOfParallelismLevel3 { get; } = Environment.ProcessorCount - 4 > 1 ? Environment.ProcessorCount - 4 : 1;
        internal static int MaxDegreesOfParallelismLevel4 { get; } = Environment.ProcessorCount - 6 > 1 ? Environment.ProcessorCount - 6 : 1;
        internal static IRandomGenerationAlgorithm RandomGenerator { get; } = new DotNetGenerator();
        internal static double LengthConversionFactor { get; } = 0d;
        internal static double MassConversionFactor { get; } = 0d;
        internal static double TimeConversionFactor { get; } = 0d;
        internal static double TemperatureConversionFactor { get; } = 0d;
        internal static float LuminosityConversionFactor { get; } = 0f;
        internal static double ElectricalCurrentConversionFactor { get; } = 0d;
        internal static SizeType SizeMeaning { get; } = SizeType.Diameter;
        internal static bool ApplyGravitationalEffectsPreventDarkMatterClumping { get; } = true;
        internal static bool ApplyGravitationalEffectsDampenBaryonicMatter { get; } = true;
        internal static float MinimumDarkMatterDistanceToPreventClumping { get; } = 0.1f;
        internal static float BaryonicMatterDampeningFactor { get; } = 0.5f;
        internal static float InteriorObjectOverlapThreshold { get; } = 0.0005f;
    }
}