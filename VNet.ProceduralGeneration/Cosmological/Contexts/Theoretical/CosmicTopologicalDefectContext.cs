using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;

public class CosmicTopologicalDefectContext : ContextBase
{
    public CosmicTopologicalDefectContext()
    {

    }

    public CosmicTopologicalDefectContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}