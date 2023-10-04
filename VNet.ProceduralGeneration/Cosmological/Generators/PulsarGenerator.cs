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

    protected override float GenerateAge(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }
}