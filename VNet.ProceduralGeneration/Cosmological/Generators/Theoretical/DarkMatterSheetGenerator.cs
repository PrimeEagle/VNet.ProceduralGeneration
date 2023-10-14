using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DarkMatterSheetGenerator : SheetGeneratorBase<DarkMatterSheet, DarkMatterSheetContext>
{
    public DarkMatterSheetGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<DarkMatterSheet> GenerateSelf(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }
}