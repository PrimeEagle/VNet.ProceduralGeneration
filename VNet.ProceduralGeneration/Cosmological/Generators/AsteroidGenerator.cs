using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AsteroidGenerator : BaseGenerator<Asteroid, AsteroidContext>
{
    public override async Task<Asteroid> Generate(AsteroidContext context)
    {
        var asteroid = new Asteroid
        {
        };

        return asteroid;
    }

    public AsteroidGenerator() : base(ParallelismLevel.Level4)
    {
    }
}