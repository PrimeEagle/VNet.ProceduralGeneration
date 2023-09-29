using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicBubbleGenerator : BaseGenerator<CosmicBubble, CosmicBubbleContext>
{
    public CosmicBubbleGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override CosmicBubble Generate(CosmicBubbleContext context)
    {
        throw new NotImplementedException();
    }
}