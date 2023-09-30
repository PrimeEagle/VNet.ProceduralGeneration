using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicBubbleGenerator : BaseGenerator<CosmicBubble, CosmicBubbleContext>
{
    public CosmicBubbleGenerator()
    {
    }

    public async override Task<CosmicBubble> Generate(CosmicBubbleContext context)
    {
        var result = new CosmicBubble();

        return result;
    }
}