using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class QuarkStarGenerator : GeneratorBase<QuarkStar, QuarkStarContext>
{
    public QuarkStarGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<QuarkStar> GenerateSelf(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }
}