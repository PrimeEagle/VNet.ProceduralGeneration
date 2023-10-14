using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterSheetStructureGenerator : SheetStructureGenerator<BaryonicMatterSheetStructure, BaryonicMatterSheetStructureContext>

{
    public BaryonicMatterSheetStructureGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<BaryonicMatterSheetStructure> GenerateSelf(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }
}