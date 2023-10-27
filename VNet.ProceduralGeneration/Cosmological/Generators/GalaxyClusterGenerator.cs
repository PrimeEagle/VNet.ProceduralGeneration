using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyClusterGenerator : GroupGeneratorBase<GalaxyCluster, GalaxyClusterContext>
{
    public GalaxyClusterGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task<GalaxyCluster> GenerateSelf(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }
}