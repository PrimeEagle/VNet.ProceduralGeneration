using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class VoidGalaxyGenerator : GroupGeneratorBase<VoidGalaxy, VoidGalaxyContext>
{
    public VoidGalaxyGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<VoidGalaxyGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }

    protected override Task<VoidGalaxy> GenerateSelf(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }
}