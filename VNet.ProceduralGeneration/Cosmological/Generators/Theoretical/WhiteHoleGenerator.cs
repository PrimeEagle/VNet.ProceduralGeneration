using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class WhiteHoleGenerator : BaseGenerator<WhiteHole, WhiteHoleContext>
{
    public WhiteHoleGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<WhiteHole> GenerateSelf(WhiteHoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(WhiteHole self, WhiteHoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(WhiteHole self, WhiteHoleContext context)
    {
        throw new NotImplementedException();
    }
}