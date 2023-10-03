using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarGenerator : GeneratorBase<Star, StarContext>
{
    public StarGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
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

    protected override float CalculateAge(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }
}