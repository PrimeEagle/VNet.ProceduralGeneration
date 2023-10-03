using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterSheetGenerator : GeneratorBase<DarkMatterSheet, DarkMatterSheetContext>
{
    public DarkMatterSheetGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
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