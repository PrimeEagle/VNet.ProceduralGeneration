using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class PlanckStarGenerator : BaseGenerator<PlanckStar, PlanckStarContext>
{
    public PlanckStarGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override PlanckStar Generate(PlanckStarContext context)
    {
        throw new NotImplementedException();
    }
}