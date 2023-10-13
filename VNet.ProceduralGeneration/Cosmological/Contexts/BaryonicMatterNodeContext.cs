using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class BaryonicMatterNodeContext : NodeContext
{
    public BaryonicMatterNodeContext()
    {
    }

    public BaryonicMatterNodeContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties(cosmicWeb);
    }

    public SpatialGrid SpatialGrid { get; init; }
    public CosmicWebHeightmapTopology Topology { get; init; }
}