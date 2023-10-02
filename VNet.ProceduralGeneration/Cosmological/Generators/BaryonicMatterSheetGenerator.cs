using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterSheetGenerator : BaseGenerator<BaryonicMatterSheet, BaryonicMatterSheetContext>
{
    public BaryonicMatterSheetGenerator() : base(ParallelismLevel.Level1)
    {
    }

    protected override Task<BaryonicMatterSheet> GenerateSelf(BaryonicMatterSheetContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterSheet self, BaryonicMatterSheetContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(BaryonicMatterSheet self, BaryonicMatterSheetContext context)
    {
        throw new NotImplementedException();
    }
}