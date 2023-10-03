using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PlanckStarGenerator : GeneratorBase<PlanckStar, PlanckStarContext>
{
    public PlanckStarGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
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

    protected override Task PostProcess(PlanckStar self, PlanckStarContext context)
    {
        throw new NotImplementedException();
    }
}