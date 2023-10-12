using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PlanckStarGenerator : GeneratorBase<PlanckStar, PlanckStarContext>
{
    public PlanckStarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
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