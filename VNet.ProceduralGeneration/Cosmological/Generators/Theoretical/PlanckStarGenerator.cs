using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PlanckStarGenerator : BaseGenerator<PlanckStar, PlanckStarContext>
{
    public PlanckStarGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<PlanckStar> Generate(PlanckStarContext context)
    {
        var result = new PlanckStar();
        return result;
    }
}