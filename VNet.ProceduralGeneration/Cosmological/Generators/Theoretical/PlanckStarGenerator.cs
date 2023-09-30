using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class PlanckStarGenerator : BaseGenerator<PlanckStar, PlanckStarContext>
{
    public PlanckStarGenerator()
    {
    }

    public async override Task<PlanckStar> Generate(PlanckStarContext context)
    {
        var result = new PlanckStar();
        return result;
    }
}