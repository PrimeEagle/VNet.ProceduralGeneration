using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CosmicDustLaneGenerator : GeneratorBase<CosmicDustLane, CosmicDustLaneContext>
{
    public CosmicDustLaneGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<CosmicDustLaneGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    protected override Task<CosmicDustLane> GenerateSelf(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }
}