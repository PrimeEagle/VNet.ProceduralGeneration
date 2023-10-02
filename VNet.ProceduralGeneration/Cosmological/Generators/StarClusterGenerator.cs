using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarClusterGenerator : BaseGenerator<StarCluster, StarClusterContext>
{
    public StarClusterGenerator() : base(ParallelismLevel.Level4)
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