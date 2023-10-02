using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class SpatialWormholeGenerator : BaseGenerator<SpatialWormhole, SpatialWormholeContext>
{
    public SpatialWormholeGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<SpatialWormhole> GenerateSelf(SpatialWormholeContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SpatialWormhole self, SpatialWormholeContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(SpatialWormhole self, SpatialWormholeContext context)
    {
        throw new NotImplementedException();
    }
}