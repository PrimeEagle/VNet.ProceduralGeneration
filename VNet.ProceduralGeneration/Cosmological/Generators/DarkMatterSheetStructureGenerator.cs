using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterSheetStructureGenerator<T, TContext> : SheetStructureGenerator<T, TContext>
                                                                    where T : SheetStructure, new()
                                                                    where TContext : SheetStructureContext
{
    public DarkMatterSheetStructureGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<T> GenerateSelf(TContext context, T self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(TContext context, T self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(TContext context, T self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(TContext context, T self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(TContext context, T self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(TContext context, T self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(TContext context, T self)
    {
        throw new NotImplementedException();
    }
}