﻿namespace VNet.ProceduralGeneration.Cosmological;

public class StarSystemGenerator : IGeneratable<StarSystem, StarSystemContext>
{
    private readonly StarGenerator _starGenerator = new StarGenerator();
    private readonly PlanetGenerator _planetGenerator = new PlanetGenerator();
    private readonly IcyPlanetGenerator _icyPlanetGenerator = new IcyPlanetGenerator();
    private readonly IcyCloudGenerator _icyCloudGenerator = new IcyCloudGenerator();
    private readonly AsteroidBeltGenerator _asteroidBeltGenerator = new AsteroidBeltGenerator();

    public StarSystem Generate(StarSystemContext context)
    {
        var starSystem = new StarSystem();

        // Generate Stars for this StarSystem
        int starCount = 0/* determine count based on some logic */;
        for (int i = 0; i < starCount; i++)
        {
            starSystem.Stars.Add(_starGenerator.Generate());
        }

        // Generate Planets for this StarSystem
        int planetCount = 0/* determine count based on some logic */;
        for (int i = 0; i < planetCount; i++)
        {
            starSystem.Planets.Add(_planetGenerator.Generate());
        }

        int icyPlanetCount = 0/* determine count based on some logic */;
        for (int i = 0; i < icyPlanetCount; i++)
        {
            starSystem.IcyPlanets.Add(_icyPlanetGenerator.Generate());
        }

        int icyCloudCount = 0/* determine count based on some logic */;
        for (int i = 0; i < icyCloudCount; i++)
        {
            starSystem.IcyClouds.Add(_icyCloudGenerator.Generate());
        }

        // Generate Asteroid Belts for this StarSystem
        int asteroidBeltCount = 0/* determine count based on some logic */;
        for (int i = 0; i < asteroidBeltCount; i++)
        {
            starSystem.AsteroidBelts.Add(_asteroidBeltGenerator.Generate());
        }

        // Other generation logic for additional celestial objects within the StarSystem

        return starSystem;
    }
}