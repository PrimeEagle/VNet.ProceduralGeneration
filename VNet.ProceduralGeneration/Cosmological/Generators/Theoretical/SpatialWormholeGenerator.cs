using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class SpatialWormholeGenerator : GeneratorBase<SpatialWormhole, SpatialWormholeContext>
{
    public SpatialWormholeGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<SpatialWormhole> GenerateSelf(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }
}