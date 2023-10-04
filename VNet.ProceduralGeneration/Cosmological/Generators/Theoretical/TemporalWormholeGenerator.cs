using System.Numerics;
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

    protected override Task<TemporalWormhole> GenerateSelf(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }
}