using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class TransdimensionalWormholeGenerator : GeneratorBase<TransdimensionalWormhole, TransdimensionalWormholeContext>
{
    public TransdimensionalWormholeGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<TransdimensionalWormhole> GenerateSelf(TransdimensionalWormholeContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(TransdimensionalWormhole self, TransdimensionalWormholeContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(TransdimensionalWormhole self, TransdimensionalWormholeContext context)
    {
        throw new NotImplementedException();
    }
}