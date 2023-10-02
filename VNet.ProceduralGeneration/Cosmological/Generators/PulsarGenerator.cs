using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PulsarGenerator : BaseGenerator<Pulsar, PulsarContext>
{
    public PulsarGenerator() : base(ParallelismLevel.Level4)
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