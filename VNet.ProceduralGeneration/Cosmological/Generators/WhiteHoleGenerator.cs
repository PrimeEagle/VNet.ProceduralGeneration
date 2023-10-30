using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class WhiteHoleGenerator : GeneratorBase<WhiteHole, WhiteHoleContext>
{
    public WhiteHoleGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService,
                              IConfigurationService configurationService, ILogger<WhiteHoleGenerator> loggerService,
                              IAstronomicalObjectCalculationService calculationService)
                              : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task<WhiteHole> GenerateSelf(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }
}