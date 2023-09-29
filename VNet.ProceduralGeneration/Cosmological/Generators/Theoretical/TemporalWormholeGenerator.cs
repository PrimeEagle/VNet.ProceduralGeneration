using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class TemporalWormholeGenerator : BaseGenerator<TemporalWormhole, TemporalWormholeContext>
{
    public TemporalWormholeGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override TemporalWormhole Generate(TemporalWormholeContext context)
    {
        throw new NotImplementedException();
    }
}