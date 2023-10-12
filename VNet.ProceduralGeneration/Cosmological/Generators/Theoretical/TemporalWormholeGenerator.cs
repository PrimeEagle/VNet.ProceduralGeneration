using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class TemporalWormholeGenerator : GeneratorBase<TemporalWormhole, TemporalWormholeContext>
{
    public TemporalWormholeGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task<TemporalWormhole> GenerateSelf(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }
}