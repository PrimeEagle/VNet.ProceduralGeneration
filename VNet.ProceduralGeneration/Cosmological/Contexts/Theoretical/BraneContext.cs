namespace VNet.ProceduralGeneration.Cosmological;

public class BraneContext : BaseContext
{
    public BraneContext()
    {

    }

    public BraneContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}