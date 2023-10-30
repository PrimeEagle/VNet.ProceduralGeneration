using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarSystemGenerator : GroupGeneratorBase<StarSystem, StarSystemContext>
{
    public StarSystemGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<StarSystemGenerator> loggerService, IAstronomicalObjectCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override Task<StarSystem> GenerateSelf(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }
}