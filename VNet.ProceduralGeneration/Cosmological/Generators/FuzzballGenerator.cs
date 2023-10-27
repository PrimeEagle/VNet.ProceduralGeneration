using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class FuzzballGenerator : GeneratorBase<Fuzzball, FuzzballContext>
{
    public FuzzballGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<FuzzballGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Fuzzball> GenerateSelf(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }
}