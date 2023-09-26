namespace VNet.ProceduralGeneration.Cosmological;

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
}