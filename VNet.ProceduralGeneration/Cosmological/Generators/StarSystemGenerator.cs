﻿using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class StarSystemGenerator : BaseGenerator<StarSystem, StarSystemContext>
{
    private readonly StarGenerator _starGenerator;
    private readonly PlanetGenerator _planetGenerator;
    private readonly IcyPlanetGenerator _icyPlanetGenerator;
    private readonly IcyCloudGenerator _icyCloudGenerator;
    private readonly AsteroidBeltGenerator _asteroidBeltGenerator;


    public async override Task<StarSystem> Generate(StarSystemContext context)
    {
        var starSystem = new StarSystem();

        int starCount = 0;
        for (int i = 0; i < starCount; i++)
        {
            starSystem.Stars.Add(_starGenerator.Generate(new StarContext()));
        }

        int planetCount = 0;
        for (int i = 0; i < planetCount; i++)
        {
            starSystem.Planets.Add(_planetGenerator.Generate(new PlanetContext()));
        }

        int icyPlanetCount = 0;
        for (int i = 0; i < icyPlanetCount; i++)
        {
            starSystem.IcyPlanets.Add(_icyPlanetGenerator.Generate(new IcyPlanetContext()));
        }

        int icyCloudCount = 0;
        for (int i = 0; i < icyCloudCount; i++)
        {
            starSystem.IcyClouds.Add(_icyCloudGenerator.Generate(new IcyCloudContext()));
        }

        int asteroidBeltCount = 0;
        for (int i = 0; i < asteroidBeltCount; i++)
        {
            starSystem.AsteroidBelts.Add(_asteroidBeltGenerator.Generate(new AsteroidBeltContext()));
        }

        return starSystem;
    }

    public StarSystemGenerator()
    {
        _starGenerator = new StarGenerator();
        _planetGenerator = new PlanetGenerator();
        _icyPlanetGenerator = new IcyPlanetGenerator();
        _icyCloudGenerator = new IcyCloudGenerator();
        _asteroidBeltGenerator = new AsteroidBeltGenerator();
    }
}