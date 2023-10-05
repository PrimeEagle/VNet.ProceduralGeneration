using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PreonStarGenerator : GeneratorBase<PreonStar, PreonStarContext>
{
    public PreonStarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
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
}