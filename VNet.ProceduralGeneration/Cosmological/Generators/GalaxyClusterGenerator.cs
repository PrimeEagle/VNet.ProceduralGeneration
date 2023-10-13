using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyClusterGenerator : GroupGeneratorBase<GalaxyCluster, GalaxyClusterContext>
{
    public GalaxyClusterGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<GalaxyCluster> GenerateSelf(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(GalaxyClusterContext context, GalaxyCluster self)
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

    protected override void GenerateSurfaceNoiseAlgorithm(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }
}