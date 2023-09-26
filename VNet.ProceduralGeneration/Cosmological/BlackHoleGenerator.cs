namespace VNet.ProceduralGeneration.Cosmological;

public class BlackHoleGenerator : IGeneratable<BlackHole, BlackHoleContext>
{
    public BlackHole Generate(BlackHoleContext context)
    {
        var blackHole = new BlackHole
        {

        };

        return blackHole;
    }
}