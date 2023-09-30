using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicBubbleGenerator : BaseGenerator<CosmicBubble, CosmicBubbleContext>
{
    public CosmicBubbleGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<CosmicBubble> Generate(CosmicBubbleContext context)
    {
        var result = new CosmicBubble();

        return result;
    }
}