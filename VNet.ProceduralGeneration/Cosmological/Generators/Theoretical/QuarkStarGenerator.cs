using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class QuarkStarGenerator : BaseGenerator<QuarkStar, QuarkStarContext>
{
    public QuarkStarGenerator()
    {
    }

    public async override Task<QuarkStar> Generate(QuarkStarContext context)
    {
        var result = new QuarkStar();
        return result;
    }
}