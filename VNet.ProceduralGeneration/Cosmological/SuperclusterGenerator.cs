namespace VNet.ProceduralGeneration.Cosmological;

public class SuperclusterGenerator : IGeneratable<Supercluster, SuperclusterContext>
{
    private readonly GalaxyClusterGenerator _galaxyClusterGenerator = new GalaxyClusterGenerator();

    public Supercluster Generate(SuperclusterContext context)
    {
        var supercluster = new Supercluster
        {
        };

        int galaxyClusterCount = 0;
        for (int i = 0; i < galaxyClusterCount; i++)
        {
            supercluster.GalaxyClusters.Add(_galaxyClusterGenerator.Generate(new GalaxyClusterContext()));
        }

        return supercluster;
    }
}