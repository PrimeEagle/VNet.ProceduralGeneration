namespace VNet.ProceduralGeneration.Cosmological;

public class PlanetGenerator : IGeneratable<Planet, PlanetContext>
{
    private readonly MoonGenerator _sateliteGenerator = new MoonGenerator();


    public Planet Generate(PlanetContext context)
    {
        var planet = new Planet();


        int satelliteCount = 0;
        for (int i = 0; i < satelliteCount; i++)
        {
            planet.Moons.Add(_sateliteGenerator.Generate(new MoonContext()));
        }

        return planet;
    }
}