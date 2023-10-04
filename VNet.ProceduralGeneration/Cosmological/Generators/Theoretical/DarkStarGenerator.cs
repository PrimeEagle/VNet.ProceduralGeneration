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

    protected override float GenerateAge(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }
}