namespace VNet.ProceduralGeneration.Cosmological;

public class IcyPlanetGenerator : IGeneratable<IcyPlanet, IcyPlanetContext>
{
    public IcyPlanet Generate(IcyPlanetContext context)
    {
        var icyPlanet = new IcyPlanet
        {
            // ... Generate properties specific to IcyPlanet
        };
        return icyPlanet;
    }
}