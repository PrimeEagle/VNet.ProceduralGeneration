using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class SpatialWormholeGenerator : GeneratorBase<SpatialWormhole, SpatialWormholeContext>
{
    public SpatialWormholeGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task<SpatialWormhole> GenerateSelf(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }
}