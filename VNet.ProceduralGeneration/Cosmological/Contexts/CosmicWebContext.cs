using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class CosmicWebContext : ContextBase
{
    public CosmicWebContext()
    {

    }

    public CosmicWebContext(Universe universe)
    {
        LoadBaseProperties((AstronomicalObject)universe);
    }
}