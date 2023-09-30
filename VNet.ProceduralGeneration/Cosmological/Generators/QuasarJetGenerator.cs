using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class QuasarJetGenerator : BaseGenerator<QuasarJet, QuasarJetContext>
{
    public async override Task<QuasarJet> Generate(QuasarJetContext context)
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