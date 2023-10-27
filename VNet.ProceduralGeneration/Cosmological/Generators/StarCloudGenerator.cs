using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarCloudGenerator : GroupGeneratorBase<StarCloud, StarCloudContext>
{
    public StarCloudGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<StarCloudGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override Task<StarCloud> GenerateSelf(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }
}