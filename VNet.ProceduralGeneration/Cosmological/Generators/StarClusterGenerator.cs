using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarClusterGenerator : GeneratorBase<StarCluster, StarClusterContext>
{
    public StarClusterGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<StarCluster> GenerateSelf(StarClusterContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StarCluster self, StarClusterContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(StarCluster self, StarClusterContext context)
    {
        throw new NotImplementedException();
    }
}