using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class TemporalWormholeGenerator : BaseGenerator<TemporalWormhole, TemporalWormholeContext>
{
    public TemporalWormholeGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<TemporalWormhole> Generate(TemporalWormholeContext context)
    {
        var result = new TemporalWormhole();
        return result;
    }
}