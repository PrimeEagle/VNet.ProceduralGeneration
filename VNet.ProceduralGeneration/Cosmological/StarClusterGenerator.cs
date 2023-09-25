namespace VNet.ProceduralGeneration.Cosmological;

public class StarClusterGenerator : IGeneratable<StarCluster, StarClusterContext>
{
    // This can be further refined to specific generator types if needed (e.g., OpenClusterGenerator, GlobularClusterGenerator)
    private readonly StarSystemGenerator _starSystemGenerator = new StarSystemGenerator();

    public StarCluster Generate(StarClusterContext context)
    {
        StarCluster cluster;

        // Decide cluster type based on some logic
        if (/* some condition */ true)
        {
            cluster = new OpenCluster();
            // Add properties specific to OpenCluster
        }
        else
        {
            cluster = new GlobularCluster();
            // Add properties specific to GlobularCluster
        }

        // Generate Stars for this StarCluster
        int starCount = 0/* determine count based on some logic */;
        for (int i = 0; i < starCount; i++)
        {
            cluster.StarSystems.Add(_starSystemGenerator.Generate());
        }

        return cluster;
    }
}