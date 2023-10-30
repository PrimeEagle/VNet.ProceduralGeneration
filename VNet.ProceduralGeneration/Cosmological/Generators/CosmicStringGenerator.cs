using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CosmicStringGenerator : GeneratorBase<CosmicString, CosmicStringContext>
{
    public CosmicStringGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<CosmicStringGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override Task<CosmicString> GenerateSelf(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }
}