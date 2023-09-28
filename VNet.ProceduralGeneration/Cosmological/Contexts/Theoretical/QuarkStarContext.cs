namespace VNet.ProceduralGeneration.Cosmological;

public class QuarkStarContext : BaseContext
{
    public QuarkStarContext()
    {

    }

    public QuarkStarContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}