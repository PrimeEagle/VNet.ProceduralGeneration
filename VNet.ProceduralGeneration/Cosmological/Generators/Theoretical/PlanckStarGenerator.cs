using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PlanckStarGenerator : BaseGenerator<PlanckStar, PlanckStarContext>
{
    public PlanckStarGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<PlanckStar> GenerateSelf(PlanckStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PlanckStar self, PlanckStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PlanckStar self, PlanckStarContext context)
    {
        throw new NotImplementedException();
    }
}