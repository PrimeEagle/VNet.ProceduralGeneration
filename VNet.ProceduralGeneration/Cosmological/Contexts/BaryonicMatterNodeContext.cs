using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor

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

    public SpatialGrid? SpatialGrid { get; init; }
    public CosmicWebHeightmapTopology? Topology { get; init; }
}