using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterSheetGenerator : BaseGenerator<DarkMatterSheet, DarkMatterSheetContext>
{
    public DarkMatterSheetGenerator() : base(ParallelismLevel.Level1)
    {
    }

    protected override Task<DarkMatterSheet> GenerateSelf(DarkMatterSheetContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterSheet self, DarkMatterSheetContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkMatterSheet self, DarkMatterSheetContext context)
    {
        throw new NotImplementedException();
    }
}