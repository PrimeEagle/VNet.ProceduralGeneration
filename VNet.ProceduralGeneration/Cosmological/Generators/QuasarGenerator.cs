using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class QuasarGenerator : BaseGenerator<Quasar, QuasarContext>
{
    public QuasarGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<Quasar> GenerateSelf(QuasarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Quasar self, QuasarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Quasar self, QuasarContext context)
    {
        throw new NotImplementedException();
    }
}