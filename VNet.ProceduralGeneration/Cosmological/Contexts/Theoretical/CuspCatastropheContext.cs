namespace VNet.ProceduralGeneration.Cosmological;

public class CuspCatastropheContext : BaseContext
{
    public CuspCatastropheContext()
    {

    }

    public CuspCatastropheContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}