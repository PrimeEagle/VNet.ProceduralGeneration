using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AsteroidBeltGenerator : GeneratorBase<AsteroidBelt, AsteroidBeltContext>
{
    public AsteroidBeltGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<AsteroidBeltGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override Task<AsteroidBelt> GenerateSelf(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }
}