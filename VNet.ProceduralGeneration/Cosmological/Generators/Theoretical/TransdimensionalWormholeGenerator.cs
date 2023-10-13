using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class TransdimensionalWormholeGenerator : GeneratorBase<TransdimensionalWormhole, TransdimensionalWormholeContext>
{
    public TransdimensionalWormholeGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<TransdimensionalWormhole> GenerateSelf(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }
}