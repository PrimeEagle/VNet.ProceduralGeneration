using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyClusterGenerator : ContainerGeneratorBase<GalaxyCluster, GalaxyClusterContext>
{
    public GalaxyClusterGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task<GalaxyCluster> GenerateSelf(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }
}