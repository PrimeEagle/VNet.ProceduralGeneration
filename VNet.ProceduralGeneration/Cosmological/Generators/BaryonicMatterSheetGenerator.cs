using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterSheetGenerator : SheetGeneratorBase<BaryonicMatterSheet, BaryonicMatterSheetContext>
{
    public BaryonicMatterSheetGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<BaryonicMatterSheet> GenerateSelf(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }
}