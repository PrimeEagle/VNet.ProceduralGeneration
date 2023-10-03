using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class TemporalWormholeGenerator : GeneratorBase<TemporalWormhole, TemporalWormholeContext>
{
    public TemporalWormholeGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
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

    protected override Task PostProcess(TemporalWormhole self, TemporalWormholeContext context)
    {
        throw new NotImplementedException();
    }
}