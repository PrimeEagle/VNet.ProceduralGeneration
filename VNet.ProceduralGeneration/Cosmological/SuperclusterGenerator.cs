﻿namespace VNet.ProceduralGeneration.Cosmological;

public class SuperclusterGenerator : BaseGenerator<Supercluster, SuperclusterContext>
{
    private readonly GalaxyClusterGenerator _galaxyClusterGenerator;


    public override Supercluster Generate(SuperclusterContext context)
    {
        var supercluster = new Supercluster
        {
        };

        int galaxyClusterCount = 0;
        for (int i = 0; i < galaxyClusterCount; i++)
        {
            supercluster.GalaxyClusters.Add(_galaxyClusterGenerator.Generate(new GalaxyClusterContext()));
        }

        return supercluster;
    }

    public SuperclusterGenerator(GeneratorConfig config) : base(config)
    {
        _galaxyClusterGenerator = new GalaxyClusterGenerator(config);
    }
}