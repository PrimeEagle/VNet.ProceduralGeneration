using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterSheetGenerator : GeneratorBase<BaryonicMatterSheet, BaryonicMatterSheetContext>
{
    public BaryonicMatterSheetGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
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