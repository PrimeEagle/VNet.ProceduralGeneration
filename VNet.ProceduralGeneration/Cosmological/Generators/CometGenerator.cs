using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CometGenerator : GeneratorBase<Comet, CometContext>
{
    public CometGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<CometGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Comet> GenerateSelf(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(CometContext context, Comet self)
    {
        throw new NotImplementedException();
    }
}