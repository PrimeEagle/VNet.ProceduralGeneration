using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CosmicBubbleGenerator : GeneratorBase<CosmicBubble, CosmicBubbleContext>
{
    public CosmicBubbleGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
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

    protected override void SetMatterType(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }
}