using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicBubbleGenerator : GeneratorBase<CosmicBubble, CosmicBubbleContext>
{
    public CosmicBubbleGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override Task<CosmicBubble> GenerateSelf(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }
}