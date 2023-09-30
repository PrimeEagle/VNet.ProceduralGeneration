using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PulsarGenerator : BaseGenerator<Pulsar, PulsarContext>
{
    public override async Task<Pulsar> Generate(PulsarContext context)
    {
        var pulsar = new Pulsar
        {

        };

        return pulsar;
    }

    public PulsarGenerator() : base(ParallelismLevel.Level4)
    {
    }
}