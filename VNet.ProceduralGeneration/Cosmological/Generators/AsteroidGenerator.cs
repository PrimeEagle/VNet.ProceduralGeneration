using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AsteroidGenerator : GeneratorBase<Asteroid, AsteroidContext>
{
    public AsteroidGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Asteroid> GenerateSelf(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }
}