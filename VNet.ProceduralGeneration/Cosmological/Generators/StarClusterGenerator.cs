namespace VNet.ProceduralGeneration.Cosmological;

public class StarClusterGenerator : BaseGenerator<StarCluster, StarClusterContext>
{
    private readonly StarSystemGenerator _starSystemGenerator;


    public override StarCluster Generate(StarClusterContext context)
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

    public StarClusterGenerator(GeneratorConfig config) : base(config)
    {
        _starSystemGenerator = new StarSystemGenerator(config);
    }
}