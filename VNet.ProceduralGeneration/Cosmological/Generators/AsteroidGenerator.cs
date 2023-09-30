using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class AsteroidGenerator : BaseGenerator<Asteroid, AsteroidContext>
{
    public async override Task<Asteroid> Generate(AsteroidContext context)
    {
        var asteroid = new Asteroid
        {
        };

        return asteroid;
    }

    public AsteroidGenerator()
    {
    }
}