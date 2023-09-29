using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class CometGenerator : BaseGenerator<Comet, CometContext>
{
    public override Comet Generate(CometContext context)
    {
        var comet = new Comet
        {

        };

        return comet;
    }

    public CometGenerator(GeneratorConfig config) : base(config)
    {
    }
}