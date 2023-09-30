using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class WhiteHoleGenerator : BaseGenerator<WhiteHole, WhiteHoleContext>
{
    public WhiteHoleGenerator()
    {
    }

    public async override Task<WhiteHole> Generate(WhiteHoleContext context)
    {
        var result = new WhiteHole();

        return result;
    }
}