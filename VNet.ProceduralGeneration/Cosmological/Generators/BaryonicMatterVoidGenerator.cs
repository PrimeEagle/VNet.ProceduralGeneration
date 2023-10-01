using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterVoidGenerator : BaseGenerator<BaryonicMatterVoid, BaryonicMatterVoidContext>
{
    public BaryonicMatterVoidGenerator() : base(ParallelismLevel.Level1)
    {
    }

    protected override Task<BaryonicMatterVoid> GenerateSelf(BaryonicMatterVoidContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterVoid self, BaryonicMatterVoidContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(BaryonicMatterVoid self, BaryonicMatterVoidContext context)
    {
        throw new NotImplementedException();
    }
}