using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class QuasarJetGenerator : BaseGenerator<QuasarJet, QuasarJetContext>
{
    public QuasarJetGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<QuasarJet> GenerateSelf(QuasarJetContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(QuasarJet self, QuasarJetContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(QuasarJet self, QuasarJetContext context)
    {
        throw new NotImplementedException();
    }
}