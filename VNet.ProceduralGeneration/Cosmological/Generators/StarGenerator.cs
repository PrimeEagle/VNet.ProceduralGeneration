using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarGenerator : GeneratorBase<Star, StarContext>
{
    public StarGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<StarGenerator> loggerService, IAstronomicalObjectCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Star> GenerateSelf(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }
}