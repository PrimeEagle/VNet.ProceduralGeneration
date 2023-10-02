using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AsteroidGenerator : BaseGenerator<Asteroid, AsteroidContext>
{
    public AsteroidGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<Asteroid> GenerateSelf(AsteroidContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Asteroid self, AsteroidContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Asteroid self, AsteroidContext context)
    {
        throw new NotImplementedException();
    }
}