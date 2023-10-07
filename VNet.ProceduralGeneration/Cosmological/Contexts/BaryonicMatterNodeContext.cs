using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class BaryonicMatterNodeContext : ContextBase
{
    public SpatialGrid SpatialGrid { get; init; }
    public CosmicWebHeightmapTopology Topology { get; init; }


    public BaryonicMatterNodeContext()
    {

    }

    public BaryonicMatterNodeContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}