using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class DarkStarGenerator : BaseGenerator<DarkStar, DarkStarContext>
{
    public DarkStarGenerator()
    {
    }

    public async override Task<DarkStar> Generate(DarkStarContext context)
    {
        var result = new DarkStar();
        return result;
    }
}