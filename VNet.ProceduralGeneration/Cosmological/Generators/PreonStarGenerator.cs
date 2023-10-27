using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PreonStarGenerator : GeneratorBase<PreonStar, PreonStarContext>
{
    public PreonStarGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<PreonStarGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task<PreonStar> GenerateSelf(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }
}