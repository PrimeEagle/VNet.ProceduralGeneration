﻿using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class StellarFormationsAndObjectsGenerator : BaseGenerator<StellarFormationsAndObjects, StellarFormationsAndObjectsContext>
{
    private readonly NebulaGenerator _nebulaGenerator;
    private readonly SupernovaGenerator _supernovaGenerator;
    private readonly BlackHoleGenerator _blackHoleGenerator;
    private readonly NeutronStarGenerator _neutronStarGenerator;


    public override StellarFormationsAndObjects Generate(StellarFormationsAndObjectsContext context)
    {
        var formationsAndObjects = new StellarFormationsAndObjects
        {
        };

        int nebulaCount = 0;
        for (int i = 0; i < nebulaCount; i++)
        {
            formationsAndObjects.Nebulae.Add(_nebulaGenerator.Generate(new NebulaContext()));
        }

        int supernovaCount = 0;
        for (int i = 0; i < supernovaCount; i++)
        {
            formationsAndObjects.Supernovae.Add(_supernovaGenerator.Generate(new SupernovaContext()));
        }

        formationsAndObjects.BlackHole = _blackHoleGenerator.Generate(new BlackHoleContext());

        int neutronStarCount = 0;
        for (int i = 0; i < neutronStarCount; i++)
        {
            formationsAndObjects.NeutronStars.Add(_neutronStarGenerator.Generate(new NeutronStarContext()));
        }

        return formationsAndObjects;
    }

    public StellarFormationsAndObjectsGenerator(GeneratorConfig config) : base(config)
    {
        _nebulaGenerator = new NebulaGenerator(config);
        _supernovaGenerator = new SupernovaGenerator(config);
        _blackHoleGenerator = new BlackHoleGenerator(config);
        _neutronStarGenerator = new NeutronStarGenerator(config);
    }
}