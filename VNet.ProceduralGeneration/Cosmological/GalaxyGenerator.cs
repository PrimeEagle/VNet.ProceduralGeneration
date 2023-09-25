namespace VNet.ProceduralGeneration.Cosmological;

public class GalaxyGenerator : IGeneratable<Galaxy, GalaxyContext>
{
    private readonly StarClusterGenerator _starClusterGenerator = new StarClusterGenerator();

    public Galaxy Generate(GalaxyContext context)
    {
        var galaxy = new Galaxy
        {
            // ... Generate properties specific to Galaxy
        };

        // Generate StarClusters for this Galaxy
        int starClusterCount = 0/* determine count based on some logic */;
        for (int i = 0; i < starClusterCount; i++)
        {
            galaxy.StarClusters.Add(_starClusterGenerator.Generate());
        }

        return galaxy;
    }
}