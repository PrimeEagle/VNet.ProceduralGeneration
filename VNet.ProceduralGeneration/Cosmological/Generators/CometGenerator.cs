using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class CometGenerator : BaseGenerator<Comet, CometContext>
{
    public async override Task<Comet> Generate(CometContext context)
    {
        var comet = new Comet
        {

        };

        return comet;
    }

    public CometGenerator()
    {
    }
}