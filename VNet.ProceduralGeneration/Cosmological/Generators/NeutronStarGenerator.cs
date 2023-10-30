using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NeutronStarGenerator : GeneratorBase<NeutronStar, NeutronStarContext>
{
    public NeutronStarGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<NeutronStarGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task<NeutronStar> GenerateSelf(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }
}