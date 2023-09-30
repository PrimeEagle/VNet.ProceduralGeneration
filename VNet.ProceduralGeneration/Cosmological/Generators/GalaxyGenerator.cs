using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class GalaxyGenerator : BaseGenerator<Galaxy, GalaxyContext>
{
    private readonly StarClusterGenerator _starClusterGenerator;


    public async override Task<Galaxy> Generate(GalaxyContext context)
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

    public GalaxyGenerator()
    {
        _starClusterGenerator = new StarClusterGenerator();
    }
}