using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicStringGenerator : BaseGenerator<CosmicString, CosmicStringContext>
{
    public CosmicStringGenerator()
    {
    }

    public async override Task<CosmicString> Generate(CosmicStringContext context)
    {
        var result = new CosmicString();
        return result;
    }
}