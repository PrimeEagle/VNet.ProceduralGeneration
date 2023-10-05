using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarGenerator : GeneratorBase<Star, StarContext>
{
    public StarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Star> GenerateSelf(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }
}