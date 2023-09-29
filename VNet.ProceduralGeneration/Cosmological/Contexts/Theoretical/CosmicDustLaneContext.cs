namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicDustLaneContext : BaseContext
{
    public CosmicDustLaneContext()
    {

    }

    public CosmicDustLaneContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}