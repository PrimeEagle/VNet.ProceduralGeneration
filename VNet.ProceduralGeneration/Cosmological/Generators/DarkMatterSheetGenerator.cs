using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterSheetGenerator : SheetGeneratorBase<DarkMatterSheet, DarkMatterSheetContext>
{
    public DarkMatterSheetGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DarkMatterSheet> GenerateSelf(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }
}