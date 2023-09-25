namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicWebGenerator : IGeneratable<CosmicWeb, CosmicWebContext>
{
    private readonly FilamentGenerator _filamentGenerator = new FilamentGenerator();

    public CosmicWeb Generate(CosmicWebContext context)
    {
        var cosmicWeb = new CosmicWeb
        {
            // ... Generate properties specific to CosmicWeb
        };

        // Generate Filaments for this CosmicWeb
        int filamentCount = 0/* determine count based on some logic */;
        for (int i = 0; i < filamentCount; i++)
        {
            cosmicWeb.Filaments.Add(_filamentGenerator.Generate());
        }

        return cosmicWeb;
    }
}