namespace VNet.ProceduralGeneration.Cosmological;

public class GalaxyClusterGenerator : IGeneratable<GalaxyCluster, GalaxyClusterContext>
{
    private readonly GalaxyGenerator _galaxyGenerator = new GalaxyGenerator();

    public GalaxyCluster Generate(GalaxyClusterContext context)
    {
        var galaxyCluster = new GalaxyCluster
        {
            // ... Generate properties specific to GalaxyCluster
        };

        // Generate Galaxies for this GalaxyCluster
        int galaxyCount = 0/* determine count based on some logic */;
        for (int i = 0; i < galaxyCount; i++)
        {
            galaxyCluster.Galaxies.Add(_galaxyGenerator.Generate());
        }

        return galaxyCluster;
    }
}