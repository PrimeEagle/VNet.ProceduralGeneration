using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterVoidGenerator : BaseGenerator<DarkMatterVoid, DarkMatterVoidContext>
{
    public DarkMatterVoidGenerator() : base(ParallelismLevel.Level1)
    {
    }

    protected override Task<DarkMatterVoid> GenerateSelf(DarkMatterVoidContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterVoid self, DarkMatterVoidContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(DarkMatterVoid self, DarkMatterVoidContext context)
    {
        throw new NotImplementedException();
    }
}