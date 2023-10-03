using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PreonStarGenerator : GeneratorBase<PreonStar, PreonStarContext>
{
    public PreonStarGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<PreonStar> GenerateSelf(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }
}