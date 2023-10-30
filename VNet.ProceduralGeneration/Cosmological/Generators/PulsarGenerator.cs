using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PulsarGenerator : GeneratorBase<Pulsar, PulsarContext>
{
    public PulsarGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<PulsarGenerator> loggerService, IAstronomicalObjectCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Pulsar> GenerateSelf(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(PulsarContext context, Pulsar self)
    {
        throw new NotImplementedException();
    }
}