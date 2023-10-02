using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class TransdimensionalWormholeGenerator : BaseGenerator<TransdimensionalWormhole, TransdimensionalWormholeContext>
{
    public TransdimensionalWormholeGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<TransdimensionalWormhole> GenerateSelf(TransdimensionalWormholeContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(TransdimensionalWormhole self, TransdimensionalWormholeContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(TransdimensionalWormhole self, TransdimensionalWormholeContext context)
    {
        throw new NotImplementedException();
    }
}