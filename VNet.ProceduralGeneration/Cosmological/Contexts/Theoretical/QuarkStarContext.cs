using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;

public class QuarkStarContext : BaseContext
{
    public QuarkStarContext()
    {

    }

    public QuarkStarContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}