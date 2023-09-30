using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyClusterGenerator : BaseGenerator<GalaxyCluster, GalaxyClusterContext>
{
    public override async Task<GalaxyCluster> Generate(GalaxyClusterContext context)
    {
        throw new NotImplementedException();
    }

    public GalaxyClusterGenerator() : base(ParallelismLevel.Level2)
    {
    }
}