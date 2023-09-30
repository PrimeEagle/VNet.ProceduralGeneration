using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class SpatialWormholeGenerator : BaseGenerator<SpatialWormhole, SpatialWormholeContext>
{
    public SpatialWormholeGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<SpatialWormhole> Generate(SpatialWormholeContext context)
    {
        var result = new SpatialWormhole();
        return result;
    }
}