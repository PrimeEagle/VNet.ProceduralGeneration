using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class DarkMatterNodeContext : ContextBase
{
    public SpatialGrid SpatialGrid { get; set; }


    public DarkMatterNodeContext()
    {

    }

    public DarkMatterNodeContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}