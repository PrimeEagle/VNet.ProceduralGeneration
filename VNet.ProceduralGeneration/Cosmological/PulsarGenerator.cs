﻿namespace VNet.ProceduralGeneration.Cosmological;

public class PulsarGenerator : BaseGenerator<Pulsar, PulsarContext>
{
    public override Pulsar Generate(PulsarContext context)
    {
        var pulsar = new Pulsar
        {

        };

        return pulsar;
    }

    public PulsarGenerator(GeneratorConfig config) : base(config)
    {
    }
}