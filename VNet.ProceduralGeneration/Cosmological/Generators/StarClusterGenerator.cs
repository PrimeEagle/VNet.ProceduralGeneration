using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class StarClusterGenerator : BaseGenerator<StarCluster, StarClusterContext>
{
    private readonly StarSystemGenerator _starSystemGenerator;


    public override StarCluster Generate(StarClusterContext context)
    {
        StarCluster cluster = new StarCluster();

        return cluster;
    }

    public StarClusterGenerator()
    {
        _starSystemGenerator = new StarSystemGenerator();
    }
}