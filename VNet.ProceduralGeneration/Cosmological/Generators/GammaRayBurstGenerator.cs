using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GammaRayBurstGenerator : BaseGenerator<GammaRayBurst, GammaRayBurstContext>
{
    public GammaRayBurstGenerator() : base(ParallelismLevel.Level4)
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

    protected override void PostProcess(GammaRayBurst self, GammaRayBurstContext context)
    {
        throw new NotImplementedException();
    }
}