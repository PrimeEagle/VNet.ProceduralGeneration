using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;

public class TransdimensionalWormholeContext : BaseContext
{
    public TransdimensionalWormholeContext()
    {

    }

    public TransdimensionalWormholeContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}