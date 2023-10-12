using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DarkStarGenerator : GeneratorBase<DarkStar, DarkStarContext>
{
    public DarkStarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DarkStar> GenerateSelf(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }
}