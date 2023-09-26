namespace VNet.ProceduralGeneration.Cosmological;

public class GalaxyClusterGenerator : IGeneratable<GalaxyCluster, GalaxyClusterContext>
{
    private readonly GalaxyGenerator _galaxyGenerator = new GalaxyGenerator();

    public GalaxyCluster Generate(GalaxyClusterContext context)
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
}