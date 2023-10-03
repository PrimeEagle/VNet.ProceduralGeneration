using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyClusterGenerator : GeneratorBase<GalaxyCluster, GalaxyClusterContext>
{
    public GalaxyClusterGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<GalaxyCluster> GenerateSelf(GalaxyClusterContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(GalaxyCluster self, GalaxyClusterContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(GalaxyCluster self, GalaxyClusterContext context)
    {
        throw new NotImplementedException();
    }
}