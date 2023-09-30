using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class GalaxyGroupGenerator : BaseGenerator<GalaxyGroup, GalaxyGroupContext>
{
    private readonly GalaxyGenerator _galaxyGenerator;


    public async override Task<GalaxyGroup> Generate(GalaxyGroupContext context)
    {
        var galaxyGroup = new GalaxyGroup
        {
        };

        int galaxyCount = 0;
        for (int i = 0; i < galaxyCount; i++)
        {
            galaxyGroup.Galaxies.Add(_galaxyGenerator.Generate(new GalaxyContext()));
        }

        return galaxyGroup;
    }

    public GalaxyGroupGenerator()
    {
        _galaxyGenerator = new GalaxyGenerator();
    }
}