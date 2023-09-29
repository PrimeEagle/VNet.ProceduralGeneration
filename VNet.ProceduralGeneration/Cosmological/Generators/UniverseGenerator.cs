﻿using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class UniverseGenerator : BaseGenerator<Universe, UniverseContext>
{
    private readonly CosmicWebGenerator _cosmicWebGenerator;


    public UniverseGenerator()
    {
        _cosmicWebGenerator = new CosmicWebGenerator();
    }

    public override Universe Generate(UniverseContext context)
    {
        var universe = new Universe
        {
            Age = config.RandomGenerator.NextSingle(config.Constants.MinUniverseAge, config.Constants.MaxUniverseAge),
            DarkEnergyPercent = config.RandomGenerator.NextDouble(config.Constants.MinDarkEnergyPercent, config.Constants.MaxDarkEnergyPercent),
            DarkMatterPercent = config.RandomGenerator.NextDouble(config.Constants.MinDarkMatterPercent, config.Constants.MaxDarkMatterPercent),
            BaryonicMatterPercent = config.RandomGenerator.NextDouble(config.Constants.MinBaryonicMatterPercent, config.Constants.MaxBaryonicMatterPercent),
            ConnectivityFactor = config.RandomGenerator.NextDouble(config.Constants.MinConnectivityFactor, config.Constants.MaxConnectivityFactor),
            Position = new Vector3(0, 0, 0)
        };

        var randValue = config.RandomGenerator.NextDouble();
        universe.Curvature = randValue switch
        {
            < 0.90 => CurvatureType.Flat,
            < 0.95 => CurvatureType.Spherical,
            _ => CurvatureType.Hyperbolic
        };

        var sum = universe.DarkEnergyPercent + universe.DarkMatterPercent + universe.BaryonicMatterPercent;
        universe.DarkEnergyPercent = (universe.DarkEnergyPercent / sum) * 100;
        universe.DarkMatterPercent = (universe.DarkMatterPercent / sum) * 100;
        universe.BaryonicMatterPercent = 100 - universe.DarkEnergyPercent - universe.DarkMatterPercent;
        universe.ApplyInflationEffects();

        var cosmicWebContext = new CosmicWebContext(universe);
        var imgTask = Task.Run(() => _cosmicWebGenerator.Generate(cosmicWebContext));

        Task.WaitAll(imgTask);

        universe.CosmicWeb = imgTask.Result;

        PostProcess();

        return universe;
    }

    private void PostProcess()
    {

    }
}