using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

namespace VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;

public class DarkMatterNodeContext : NodeContext
{
    public DarkMatterNodeContext()
    {
    }

    public DarkMatterNodeContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties(cosmicWeb);
    }

    public SpatialGrid SpatialGrid { get; set; }
}