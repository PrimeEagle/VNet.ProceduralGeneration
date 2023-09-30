using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class BaryonicMatterNodeContext : BaseContext
{
    public SpatialGrid SpatialGrid { get; set; }


    public BaryonicMatterNodeContext()
    {

    }

    public BaryonicMatterNodeContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}