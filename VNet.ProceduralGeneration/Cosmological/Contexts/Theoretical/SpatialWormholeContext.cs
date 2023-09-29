namespace VNet.ProceduralGeneration.Cosmological;

public class SpatialWormholeContext : BaseContext
{
    public SpatialWormholeContext()
    {

    }

    public SpatialWormholeContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}