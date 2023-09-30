using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AsteroidBeltGenerator : BaseGenerator<AsteroidBelt, AsteroidBeltContext>
{


    public override async Task<AsteroidBelt> Generate(AsteroidBeltContext context)
    {
        var asteroidBelt = new AsteroidBelt();


        return asteroidBelt;
    }

    public AsteroidBeltGenerator() : base(ParallelismLevel.Level4)
    {
    }
}