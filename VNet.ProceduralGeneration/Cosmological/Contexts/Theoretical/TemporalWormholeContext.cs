namespace VNet.ProceduralGeneration.Cosmological;

public class TemporalWormholeContext : BaseContext
{
    public TemporalWormholeContext()
    {

    }

    public TemporalWormholeContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}