namespace VNet.ProceduralGeneration.Cosmological;

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