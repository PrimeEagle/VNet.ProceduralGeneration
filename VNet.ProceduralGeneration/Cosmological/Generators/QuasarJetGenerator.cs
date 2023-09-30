using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class QuasarJetGenerator : BaseGenerator<QuasarJet, QuasarJetContext>
{
    public override async Task<QuasarJet> Generate(QuasarJetContext context)
    {
        var quasarJet = new QuasarJet
        {

        };

        return quasarJet;
    }

    public QuasarJetGenerator() : base(ParallelismLevel.Level3)
    {
    }
}