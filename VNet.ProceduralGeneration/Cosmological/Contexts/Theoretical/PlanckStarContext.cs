namespace VNet.ProceduralGeneration.Cosmological;

public class PlanckStarContext : BaseContext
{
    public PlanckStarContext()
    {

    }

    public PlanckStarContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}