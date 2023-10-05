using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PlanetGenerator : GeneratorBase<Planet, PlanetContext>
{
    public PlanetGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Planet> GenerateSelf(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }
}