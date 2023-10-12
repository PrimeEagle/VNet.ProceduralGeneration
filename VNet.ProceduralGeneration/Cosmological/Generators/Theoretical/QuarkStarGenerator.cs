using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class QuarkStarGenerator : GeneratorBase<QuarkStar, QuarkStarContext>
{
    public QuarkStarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task<QuarkStar> GenerateSelf(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }
}