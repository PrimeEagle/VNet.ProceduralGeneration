using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PulsarGenerator : BaseGenerator<Pulsar, PulsarContext>
{
    public override Pulsar Generate(PulsarContext context)
    {
        var pulsar = new Pulsar
        {

        };

        return pulsar;
    }

    public PulsarGenerator()
    {
    }
}