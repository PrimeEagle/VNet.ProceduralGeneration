using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarClusterGenerator : ContainerGeneratorBase<StarCluster, StarClusterContext>
{
    public StarClusterGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task<StarCluster> GenerateSelf(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }
}