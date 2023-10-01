using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PlanetGenerator : BaseGenerator<Planet, PlanetContext>
{
    public PlanetGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<Planet> GenerateSelf(PlanetContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Planet self, PlanetContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(Planet self, PlanetContext context)
    {
        throw new NotImplementedException();
    }
}