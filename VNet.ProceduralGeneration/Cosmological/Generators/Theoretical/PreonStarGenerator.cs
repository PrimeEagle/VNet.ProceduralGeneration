using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class PreonStarGenerator : BaseGenerator<PreonStar, PreonStarContext>
{
    public PreonStarGenerator()
    {
    }

    public async override Task<PreonStar> Generate(PreonStarContext context)
    {
        var result = new PreonStar();
        return result;
    }
}