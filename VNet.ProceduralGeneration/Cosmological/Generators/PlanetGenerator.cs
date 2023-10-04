using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PlanetGenerator : GeneratorBase<Planet, PlanetContext>
{
    public PlanetGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
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

    protected override float GenerateAge(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }
}