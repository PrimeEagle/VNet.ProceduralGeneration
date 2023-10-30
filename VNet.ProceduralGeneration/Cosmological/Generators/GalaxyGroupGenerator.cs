using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyGroupGenerator : GroupGeneratorBase<GalaxyGroup, GalaxyGroupContext>
{
    public GalaxyGroupGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<GalaxyGroupGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override Task<GalaxyGroup> GenerateSelf(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }
}