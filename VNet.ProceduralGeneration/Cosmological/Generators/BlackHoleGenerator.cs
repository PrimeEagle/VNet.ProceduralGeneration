using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class BlackHoleGenerator : BaseGenerator<BlackHole, BlackHoleContext>
{
    public override BlackHole Generate(BlackHoleContext context)
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