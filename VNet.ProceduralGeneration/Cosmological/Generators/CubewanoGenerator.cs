using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CubewanoGenerator : GeneratorBase<Cubewano, CubewanoContext>
{
    public CubewanoGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<CubewanoGenerator> loggerService, IAstronomicalObjectCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Cubewano> GenerateSelf(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }
}