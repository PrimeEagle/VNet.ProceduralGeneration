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

    protected override Task<Pulsar> GenerateSelf(PulsarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Pulsar self, PulsarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Pulsar self, PulsarContext context)
    {
        throw new NotImplementedException();
    }
}