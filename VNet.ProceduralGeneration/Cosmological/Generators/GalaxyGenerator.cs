using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyGenerator : GeneratorBase<Galaxy, GalaxyContext>
{
    public GalaxyGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Galaxy> GenerateSelf(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }
}