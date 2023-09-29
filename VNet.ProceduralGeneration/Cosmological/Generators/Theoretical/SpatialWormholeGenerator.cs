using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class SpatialWormholeGenerator : BaseGenerator<SpatialWormhole, SpatialWormholeContext>
{
    public SpatialWormholeGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override SpatialWormhole Generate(SpatialWormholeContext context)
    {
        throw new NotImplementedException();
    }
}