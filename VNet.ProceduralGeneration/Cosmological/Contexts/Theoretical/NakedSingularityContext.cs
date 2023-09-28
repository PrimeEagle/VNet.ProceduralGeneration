namespace VNet.ProceduralGeneration.Cosmological;

public class NakedSingularityContext : BaseContext
{
    public NakedSingularityContext()
    {

    }

    public NakedSingularityContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}