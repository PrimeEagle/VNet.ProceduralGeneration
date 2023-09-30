using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;

public class DarkStarContext : BaseContext
{
    public DarkStarContext()
    {

    }

    public DarkStarContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}