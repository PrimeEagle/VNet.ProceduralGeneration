using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PulsarGenerator : GeneratorBase<Pulsar, PulsarContext>
{
    public PulsarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
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
}