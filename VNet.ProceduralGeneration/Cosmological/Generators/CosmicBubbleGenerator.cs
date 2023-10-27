using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CosmicBubbleGenerator : GeneratorBase<CosmicBubble, CosmicBubbleContext>
{
    public CosmicBubbleGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<CosmicBubbleGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override Task<CosmicBubble> GenerateSelf(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(CosmicBubbleContext context, CosmicBubble self)
    {
        throw new NotImplementedException();
    }
}