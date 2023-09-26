namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicWebGenerator : IGeneratable<CosmicWeb, CosmicWebContext>
{
    private readonly FilamentGenerator _filamentGenerator = new FilamentGenerator();

    public CosmicWeb Generate(CosmicWebContext context)
    {
        var cosmicWeb = new CosmicWeb
        {

        };


        int filamentCount = 0;
        for (int i = 0; i < filamentCount; i++)
        {
            cosmicWeb.Filaments.Add(_filamentGenerator.Generate(new FilamentContext()));
        }

        return cosmicWeb;
    }
}