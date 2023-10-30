using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class QuarkStarGenerator : GeneratorBase<QuarkStar, QuarkStarContext>
{
    public QuarkStarGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<QuarkStarGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task<QuarkStar> GenerateSelf(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(QuarkStarContext context, QuarkStar self)
    {
        throw new NotImplementedException();
    }
}