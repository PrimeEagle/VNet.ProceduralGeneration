using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class BaryonicMatterNodeContext : ContextBase
{
    public SpatialGrid SpatialGrid { get; init; }
    public CosmicWebTopology Topology { get; init; }


    public BaryonicMatterNodeContext()
    {

    }

    public BaryonicMatterNodeContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}