namespace VNet.ProceduralGeneration.Cosmological;

public class StarClusterGenerator : IGeneratable<StarCluster, StarClusterContext>
{
    private readonly StarSystemGenerator _starSystemGenerator = new StarSystemGenerator();

    public StarCluster Generate(StarClusterContext context)
    {
        StarCluster cluster;


        if (true)
        {
            cluster = new OpenCluster();
        }
        else
        {
            cluster = new GlobularCluster();
        }

        int starCount = 0;
        for (int i = 0; i < starCount; i++)
        {
            cluster.StarSystems.Add(_starSystemGenerator.Generate(new StarSystemContext()));
        }

        return cluster;
    }
}