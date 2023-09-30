using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;

public class CosmicTopologicalDefectContext : BaseContext
{
    public CosmicTopologicalDefectContext()
    {

    }

    public CosmicTopologicalDefectContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}