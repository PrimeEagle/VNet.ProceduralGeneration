namespace VNet.ProceduralGeneration.Cosmological;

public class DomainWallContext : BaseContext
{
    public DomainWallContext()
    {

    }

    public DomainWallContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}