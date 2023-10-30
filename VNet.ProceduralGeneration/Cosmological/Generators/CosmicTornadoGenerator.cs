using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CosmicTornadoGenerator : GeneratorBase<CosmicTornado, CosmicTornadoContext>
{
    public CosmicTornadoGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<CosmicTornadoGenerator> loggerService, IAstronomicalObjectCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override Task<CosmicTornado> GenerateSelf(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }
}