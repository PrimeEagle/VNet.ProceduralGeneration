using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class IcyPlanetGenerator : BaseGenerator<IcyPlanet, IcyPlanetContext>
{
    public IcyPlanetGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<IcyPlanet> GenerateSelf(IcyPlanetContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(IcyPlanet self, IcyPlanetContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(IcyPlanet self, IcyPlanetContext context)
    {
        throw new NotImplementedException();
    }
}