using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DarkStarGenerator : GeneratorBase<DarkStar, DarkStarContext>
{
    public DarkStarGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<DarkStar> GenerateSelf(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }
}