using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyGenerator : GroupGeneratorBase<Galaxy, GalaxyContext>
{
    public GalaxyGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<GalaxyGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Galaxy> GenerateSelf(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }
}