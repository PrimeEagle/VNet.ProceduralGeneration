namespace VNet.ProceduralGeneration.Cosmological;

public class AsteroidBeltGenerator : IGeneratable<AsteroidBelt, AsteroidBeltContext>
{
    private readonly AsteroidGenerator _asteroidGenerator = new AsteroidGenerator();

    public AsteroidBelt Generate(AsteroidBeltContext context)
    {
        var asteroidBelt = new AsteroidBelt();

        // Generate Asteroids for this AsteroidBelt
        int asteroidCount = 0/* determine count based on some logic */;
        for (int i = 0; i < asteroidCount; i++)
        {
            asteroidBelt.Asteroids.Add(_asteroidGenerator.Generate());
        }

        // Other generation logic for AsteroidBelt

        return asteroidBelt;
    }
}