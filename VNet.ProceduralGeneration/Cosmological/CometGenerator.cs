namespace VNet.ProceduralGeneration.Cosmological;

public class CometGenerator : IGeneratable<Comet, CometContext>
{
    public Comet Generate(CometContext context)
    {
        var comet = new Comet
        {
            // ... Generate properties specific to Comet
        };
        return comet;
    }
}