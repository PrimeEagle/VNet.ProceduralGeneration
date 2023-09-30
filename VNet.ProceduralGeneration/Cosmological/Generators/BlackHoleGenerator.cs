using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class BlackHoleGenerator : BaseGenerator<BlackHole, BlackHoleContext>
{
    public async override Task<BlackHole> Generate(BlackHoleContext context)
    {
        var blackHole = new BlackHole
        {

        };

        return blackHole;
    }

    public BlackHoleGenerator()
    {
    }
}