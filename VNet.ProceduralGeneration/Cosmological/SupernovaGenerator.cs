﻿namespace VNet.ProceduralGeneration.Cosmological;

public class SupernovaGenerator : BaseGenerator<Supernova, SupernovaContext>
{
    public override Supernova Generate(SupernovaContext context)
    {
        var supernova = new Supernova
        {

        };

        return supernova;
    }

    public SupernovaGenerator(GeneratorConfig config) : base(config)
    {
    }
}