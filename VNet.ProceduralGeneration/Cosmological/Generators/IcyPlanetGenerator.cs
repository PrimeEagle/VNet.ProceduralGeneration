using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class IcyPlanetGenerator : BaseGenerator<IcyPlanet, IcyPlanetContext>
{
    public override IcyPlanet Generate(IcyPlanetContext context)
    {
        var icyPlanet = new IcyPlanet
        {

        };

        return icyPlanet;
    }

    public IcyPlanetGenerator()
    {
    }
}