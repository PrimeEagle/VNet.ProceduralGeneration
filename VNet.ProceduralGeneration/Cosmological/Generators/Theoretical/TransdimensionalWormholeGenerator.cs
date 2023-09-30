using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class TransdimensionalWormholeGenerator : BaseGenerator<TransdimensionalWormhole, TransdimensionalWormholeContext>
{
    public TransdimensionalWormholeGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<TransdimensionalWormhole> Generate(TransdimensionalWormholeContext context)
    {
        var result = new TransdimensionalWormhole();
        return result;
    }
}