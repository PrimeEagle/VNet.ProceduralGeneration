namespace VNet.ProceduralGeneration.Cosmological;

public class MonopoleContext : BaseContext
{
    public MonopoleContext()
    {

    }

    public MonopoleContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}