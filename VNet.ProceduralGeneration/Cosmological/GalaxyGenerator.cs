namespace VNet.ProceduralGeneration.Cosmological;

public class GalaxyGenerator : IGeneratable<Galaxy, GalaxyContext>
{
    private readonly StarClusterGenerator _starClusterGenerator = new StarClusterGenerator();

    public Galaxy Generate(GalaxyContext context)
    {
        var galaxy = new Galaxy
        {

        };

        int starClusterCount = 0;
        for (int i = 0; i < starClusterCount; i++)
        {
            galaxy.StarClusters.Add(_starClusterGenerator.Generate(new StarClusterContext()));
        }

        return galaxy;
    }
}