using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GammaRayBurstGenerator : BaseGenerator<GammaRayBurst, GammaRayBurstContext>
{
    public override async Task<GammaRayBurst> Generate(GammaRayBurstContext context)
    {
        throw new NotImplementedException();
    }

    public GammaRayBurstGenerator() : base(ParallelismLevel.Level4)
    {
    }
}