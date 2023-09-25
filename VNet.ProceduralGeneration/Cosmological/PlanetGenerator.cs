namespace VNet.ProceduralGeneration.Cosmological;

public class PlanetGenerator : IGeneratable<Planet, PlanetContext>
{
    private readonly MoonGenerator _sateliteGenerator = new MoonGenerator();


    public Planet Generate(PlanetContext context)
    {
        var planet = new Planet();

        // Generate Stars for this StarSystem
        int satelliteCount = 0/* determine count based on some logic */;
        for (int i = 0; i < satelliteCount; i++)
        {
            planet.Moons.Add(_sateliteGenerator.Generate());
        }

        // Other generation logic for additional celestial objects within the StarSystem

        return planet;
    }
}