using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AsteroidGenerator : GeneratorBase<Asteroid, AsteroidContext>
{
    public AsteroidGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
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

    protected override float CalculateAge(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }
}