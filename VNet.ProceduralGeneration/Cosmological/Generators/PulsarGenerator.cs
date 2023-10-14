using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PulsarGenerator : GeneratorBase<Pulsar, PulsarContext>
{
    public PulsarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
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

    protected override void SetMatterType(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }
}