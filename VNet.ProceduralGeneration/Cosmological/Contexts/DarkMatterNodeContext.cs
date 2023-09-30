using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class DarkMatterNodeContext : BaseContext
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