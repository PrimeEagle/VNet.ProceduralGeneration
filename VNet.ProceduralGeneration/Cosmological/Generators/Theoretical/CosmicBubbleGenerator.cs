using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicBubbleGenerator : GeneratorBase<CosmicBubble, CosmicBubbleContext>
{
    public CosmicBubbleGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<CosmicBubble> GenerateSelf(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }
}