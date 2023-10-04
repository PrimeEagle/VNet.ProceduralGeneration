using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GammaRayBurstGenerator : GeneratorBase<GammaRayBurst, GammaRayBurstContext>
{
    public GammaRayBurstGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
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

    protected override float GenerateAge(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }
}