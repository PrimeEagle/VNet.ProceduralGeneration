namespace VNet.ProceduralGeneration.Cosmological;

public class CometGenerator : IGeneratable<Comet, CometContext>
{
    public Comet Generate(CometContext context)
    {
        var comet = new Comet
        {

        };

        return comet;
    }
}