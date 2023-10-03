using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PulsarGenerator : GeneratorBase<Pulsar, PulsarContext>
{
    public PulsarGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Pulsar> GenerateSelf(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }
}