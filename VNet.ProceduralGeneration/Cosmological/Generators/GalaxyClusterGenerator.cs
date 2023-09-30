using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class GalaxyClusterGenerator : BaseGenerator<GalaxyCluster, GalaxyClusterContext>
{
    private readonly GalaxyGenerator _galaxyGenerator;


    public async override Task<GalaxyCluster> Generate(GalaxyClusterContext context)
    {
        var galaxyCluster = new GalaxyCluster
        {

        };


        int galaxyCount = 0;
        for (int i = 0; i < galaxyCount; i++)
        {
            galaxyCluster.Galaxies.Add(_galaxyGenerator.Generate(new GalaxyContext()));
        }

        return galaxyCluster;
    }

    public GalaxyClusterGenerator()
    {
        _galaxyGenerator = new GalaxyGenerator();
    }
}