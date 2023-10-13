using VNet.Mathematics.Randomization.Generation;
using VNet.Scientific.Noise;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace VNet.ProceduralGeneration.Cosmological.Contexts.Base;

public abstract class GroupContextBase : ContextBase
{
    public IRandomGenerationAlgorithm InteriorObjectRandomizationAlgorithm { get; init; }
    public INoiseAlgorithm SurfaceWarpingNoiseAlgorithm { get; init; }
    public float SurfaceResolution { get; init; }
    public float SurfaceWarpingFactor { get; init; }
    public int InteriorMaxContents { get; set; }
}