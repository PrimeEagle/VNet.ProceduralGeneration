namespace VNet.ProceduralGeneration.Cosmological;

public class SuperclusterGenerator : IGeneratable<Supercluster, SuperclusterContext>
{
    private readonly GalaxyClusterGenerator _galaxyClusterGenerator = new GalaxyClusterGenerator();

    public Supercluster Generate(SuperclusterContext context)
    {
        var supercluster = new Supercluster
        {
            // ... Generate properties specific to Supercluster
        };

        // Generate GalaxyClusters for this Supercluster
        int galaxyClusterCount = 0/* determine count based on some logic */;
        for (int i = 0; i < galaxyClusterCount; i++)
        {
            supercluster.GalaxyClusters.Add(_galaxyClusterGenerator.Generate());
        }

        return supercluster;
    }
}