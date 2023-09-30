using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class IcyPlanetGenerator : BaseGenerator<IcyPlanet, IcyPlanetContext>
{
    public override async Task<IcyPlanet> Generate(IcyPlanetContext context)
    {
        var icyPlanet = new IcyPlanet
        {

        };

        return icyPlanet;
    }

    public IcyPlanetGenerator() : base(ParallelismLevel.Level4)
    {
    }
}