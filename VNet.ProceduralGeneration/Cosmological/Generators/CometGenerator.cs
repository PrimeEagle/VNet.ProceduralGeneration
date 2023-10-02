using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CometGenerator : BaseGenerator<Comet, CometContext>
{
    public CometGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<Comet> GenerateSelf(CometContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Comet self, CometContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Comet self, CometContext context)
    {
        throw new NotImplementedException();
    }
}