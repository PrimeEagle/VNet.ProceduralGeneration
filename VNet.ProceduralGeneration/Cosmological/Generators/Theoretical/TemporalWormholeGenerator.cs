using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class TemporalWormholeGenerator : BaseGenerator<TemporalWormhole, TemporalWormholeContext>
{
    public TemporalWormholeGenerator()
    {
    }

    public async override Task<TemporalWormhole> Generate(TemporalWormholeContext context)
    {
        var result = new TemporalWormhole();
        return result;
    }
}