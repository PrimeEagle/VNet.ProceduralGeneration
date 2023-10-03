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

    protected override Task<GammaRayBurst> GenerateSelf(GammaRayBurstContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(GammaRayBurst self, GammaRayBurstContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(GammaRayBurst self, GammaRayBurstContext context)
    {
        throw new NotImplementedException();
    }
}