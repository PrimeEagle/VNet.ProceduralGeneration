namespace VNet.ProceduralGeneration.Cosmological;

public class DarkStarContext : BaseContext
{
    public DarkStarContext()
    {

    }

    public DarkStarContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}