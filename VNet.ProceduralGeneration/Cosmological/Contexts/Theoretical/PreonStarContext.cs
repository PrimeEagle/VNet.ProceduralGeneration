namespace VNet.ProceduralGeneration.Cosmological;

public class PreonStarContext : BaseContext
{
    public PreonStarContext()
    {

    }

    public PreonStarContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}