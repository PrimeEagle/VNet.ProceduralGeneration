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

    protected override float GenerateAge(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }
}