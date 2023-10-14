using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DarkMatterSheetStructureGenerator : SheetStructureGenerator<DarkMatterSheetStructure, DarkMatterSheetStructureContext>
{
    public DarkMatterSheetStructureGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<DarkMatterSheetStructure> GenerateSelf(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }
}