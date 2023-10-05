using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GammaRayBurstGenerator : GeneratorBase<GammaRayBurst, GammaRayBurstContext>
{
    public GammaRayBurstGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override Task<GammaRayBurst> GenerateSelf(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }
}