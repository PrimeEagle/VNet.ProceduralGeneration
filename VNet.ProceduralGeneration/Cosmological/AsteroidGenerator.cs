namespace VNet.ProceduralGeneration.Cosmological;

public class AsteroidGenerator : IGeneratable<Asteroid, AsteroidContext>
{
    public Asteroid Generate(AsteroidContext context)
    {
        var asteroid = new Asteroid
        {
        };

        return asteroid;
    }
}