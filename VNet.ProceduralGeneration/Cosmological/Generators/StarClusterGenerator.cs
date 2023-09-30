using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarClusterGenerator : BaseGenerator<StarCluster, StarClusterContext>
{
    private readonly StarSystemGenerator _starSystemGenerator;


    public override async Task<StarCluster> Generate(StarClusterContext context)
    {
        var cluster = new StarCluster();

        return cluster;
    }

    public StarClusterGenerator() : base(ParallelismLevel.Level3)
    {
        _starSystemGenerator = new StarSystemGenerator();
    }
}