namespace VNet.ProceduralGeneration.Cosmological;

public class StarSystemGenerator : BaseGenerator<StarSystem, StarSystemContext>
{
    private readonly StarGenerator _starGenerator;
    private readonly PlanetGenerator _planetGenerator;
    private readonly IcyPlanetGenerator _icyPlanetGenerator;
    private readonly IcyCloudGenerator _icyCloudGenerator;
    private readonly AsteroidBeltGenerator _asteroidBeltGenerator;


    public override StarSystem Generate(StarSystemContext context)
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

    public StarSystemGenerator(GeneratorConfig config) : base(config)
    {
        _starGenerator = new StarGenerator(config);
        _planetGenerator = new PlanetGenerator(config);
        _icyPlanetGenerator = new IcyPlanetGenerator(config);
        _icyCloudGenerator = new IcyCloudGenerator(config);
        _asteroidBeltGenerator = new AsteroidBeltGenerator(config);
    }
}