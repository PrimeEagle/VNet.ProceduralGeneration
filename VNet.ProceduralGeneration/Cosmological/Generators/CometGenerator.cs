using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CometGenerator : GeneratorBase<Comet, CometContext>
{
    public CometGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Comet> GenerateSelf(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }
}