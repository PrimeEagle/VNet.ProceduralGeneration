using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PlanckStarGenerator : GeneratorBase<PlanckStar, PlanckStarContext>
{
    public PlanckStarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<PlanckStar> GenerateSelf(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }
}