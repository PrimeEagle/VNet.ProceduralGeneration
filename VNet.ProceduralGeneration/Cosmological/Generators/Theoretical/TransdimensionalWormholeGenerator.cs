using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class TransdimensionalWormholeGenerator : BaseGenerator<TransdimensionalWormhole, TransdimensionalWormholeContext>
{
    public TransdimensionalWormholeGenerator()
    {
    }

    public async override Task<TransdimensionalWormhole> Generate(TransdimensionalWormholeContext context)
    {
        var result = new TransdimensionalWormhole();
        return result;
    }
}