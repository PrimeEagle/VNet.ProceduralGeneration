using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyClusterGenerator : BaseGenerator<GalaxyCluster, GalaxyClusterContext>
{
    public GalaxyClusterGenerator() : base(ParallelismLevel.Level4)
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