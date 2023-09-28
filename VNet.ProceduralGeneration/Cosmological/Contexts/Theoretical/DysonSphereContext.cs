namespace VNet.ProceduralGeneration.Cosmological;

public class DysonSphereContext : BaseContext
{
    public DysonSphereContext()
    {

    }

    public DysonSphereContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}