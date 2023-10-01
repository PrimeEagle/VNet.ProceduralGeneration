using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AsteroidBeltGenerator : BaseGenerator<AsteroidBelt, AsteroidBeltContext>
{
    protected override Task<AsteroidBelt> GenerateSelf(AsteroidBeltContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(AsteroidBelt self, AsteroidBeltContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(AsteroidBelt self, AsteroidBeltContext context)
    {
        throw new NotImplementedException();
    }

    public AsteroidBeltGenerator() : base(ParallelismLevel.Level4)
    {
    }
}