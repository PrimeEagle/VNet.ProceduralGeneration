namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicStringContext : BaseContext
{
    public CosmicStringContext()
    {

    }

    public CosmicStringContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}