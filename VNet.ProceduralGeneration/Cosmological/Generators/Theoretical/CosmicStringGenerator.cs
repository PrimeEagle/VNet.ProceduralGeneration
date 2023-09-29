using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicStringGenerator : BaseGenerator<CosmicString, CosmicStringContext>
{
    public CosmicStringGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override CosmicString Generate(CosmicStringContext context)
    {
        throw new NotImplementedException();
    }
}