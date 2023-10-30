using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class QuasarJetGenerator : GeneratorBase<QuasarJet, QuasarJetContext>
{
    public QuasarJetGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<QuasarJetGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override Task<QuasarJet> GenerateSelf(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }
}