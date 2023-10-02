using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicBubbleGenerator : BaseGenerator<CosmicBubble, CosmicBubbleContext>
{
    public CosmicBubbleGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<CosmicBubble> GenerateSelf(CosmicBubbleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicBubble self, CosmicBubbleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CosmicBubble self, CosmicBubbleContext context)
    {
        throw new NotImplementedException();
    }
}