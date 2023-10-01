using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PrimordialBlackHoleGenerator : BaseGenerator<PrimordialBlackHole, PrimordialBlackHoleContext>
{
    public PrimordialBlackHoleGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<PrimordialBlackHole> GenerateSelf(PrimordialBlackHoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PrimordialBlackHole self, PrimordialBlackHoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PrimordialBlackHole self, PrimordialBlackHoleContext context)
    {
        throw new NotImplementedException();
    }
}