using System.Numerics;
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

    protected override Task<PlanckStar> GenerateSelf(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }
}