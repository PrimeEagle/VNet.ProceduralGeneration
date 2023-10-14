using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarClusterGenerator : GroupGeneratorBase<StarCluster, StarClusterContext>
{
    public StarClusterGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<StarCluster> GenerateSelf(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }
}