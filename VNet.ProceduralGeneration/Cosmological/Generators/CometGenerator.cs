using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CometGenerator : GeneratorBase<Comet, CometContext>
{
    public CometGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Comet> GenerateSelf(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }
}