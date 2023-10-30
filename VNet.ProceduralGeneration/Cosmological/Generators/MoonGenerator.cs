using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class MoonGenerator : GeneratorBase<Moon, MoonContext>
{
    public MoonGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<MoonGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Moon> GenerateSelf(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }
}