using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterSheetGenerator : BaseGenerator<DarkMatterSheet, DarkMatterSheetContext>
{
    public DarkMatterSheetGenerator() : base(ParallelismLevel.Level1)
    {
    }

    public override async Task<DarkMatterSheet> Generate(DarkMatterSheetContext context)
    {
        throw new NotImplementedException();
    }
}