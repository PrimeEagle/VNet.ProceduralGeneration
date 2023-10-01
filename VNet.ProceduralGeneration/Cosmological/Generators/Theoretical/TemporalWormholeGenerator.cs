using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class TemporalWormholeGenerator : BaseGenerator<TemporalWormhole, TemporalWormholeContext>
{
    public TemporalWormholeGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<TemporalWormhole> GenerateSelf(TemporalWormholeContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(TemporalWormhole self, TemporalWormholeContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(TemporalWormhole self, TemporalWormholeContext context)
    {
        throw new NotImplementedException();
    }
}