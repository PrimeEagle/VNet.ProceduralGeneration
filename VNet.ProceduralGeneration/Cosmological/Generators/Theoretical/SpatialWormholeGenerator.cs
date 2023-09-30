using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class SpatialWormholeGenerator : BaseGenerator<SpatialWormhole, SpatialWormholeContext>
{
    public SpatialWormholeGenerator()
    {
    }

    public async override Task<SpatialWormhole> Generate(SpatialWormholeContext context)
    {
        var result = new SpatialWormhole();
        return result;
    }
}