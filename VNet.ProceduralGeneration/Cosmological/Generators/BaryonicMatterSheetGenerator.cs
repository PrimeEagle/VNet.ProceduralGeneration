using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterSheetGenerator : BaseGenerator<BaryonicMatterSheet, BaryonicMatterSheetContext>
{
    public BaryonicMatterSheetGenerator() : base(ParallelismLevel.Level1)
    {
    }

    public override async Task<BaryonicMatterSheet> Generate(BaryonicMatterSheetContext context)
    {
        throw new NotImplementedException();
    }
}