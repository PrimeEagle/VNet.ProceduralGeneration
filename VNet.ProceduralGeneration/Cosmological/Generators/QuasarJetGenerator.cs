using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class QuasarJetGenerator : BaseGenerator<QuasarJet, QuasarJetContext>
{
    public override QuasarJet Generate(QuasarJetContext context)
    {
        var quasarJet = new QuasarJet
        {

        };

        return quasarJet;
    }

    public QuasarJetGenerator()
    {
    }
}