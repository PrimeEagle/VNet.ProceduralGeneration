using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;

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