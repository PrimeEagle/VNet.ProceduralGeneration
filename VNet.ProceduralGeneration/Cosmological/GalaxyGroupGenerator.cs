namespace VNet.ProceduralGeneration.Cosmological;

public class GalaxyGroupGenerator : IGeneratable<GalaxyGroup, GalaxyGroupContext>
{
    private readonly GalaxyGenerator _galaxyGenerator = new GalaxyGenerator();

    public GalaxyGroup Generate(GalaxyGroupContext context)
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
}