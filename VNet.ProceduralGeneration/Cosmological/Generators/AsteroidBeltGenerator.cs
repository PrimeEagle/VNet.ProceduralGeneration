using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class AsteroidBeltGenerator : BaseGenerator<AsteroidBelt, AsteroidBeltContext>
{
    private readonly AsteroidGenerator _asteroidGenerator;


    public async override Task<AsteroidBelt> Generate(AsteroidBeltContext context)
    {
        var asteroidBelt = new AsteroidBelt();

        // Generate Asteroids for this AsteroidBelt
        int asteroidCount = 0/* determine count based on some logic */;
        for (int i = 0; i < asteroidCount; i++)
        {
            asteroidBelt.Asteroids.Add(_asteroidGenerator.Generate(new AsteroidContext()));
        }

        // Other generation logic for AsteroidBelt

        return asteroidBelt;
    }

    public AsteroidBeltGenerator()
    {
        _asteroidGenerator = new AsteroidGenerator();
    }
}