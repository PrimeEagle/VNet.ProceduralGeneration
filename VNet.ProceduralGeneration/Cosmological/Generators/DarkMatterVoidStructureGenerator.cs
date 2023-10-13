using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterVoidStructureGenerator<T, TContext> : VoidStructureGenerator<T, TContext>
                                                                where T : VoidStructure, new()
                                                                where TContext : VoidStructureContext
{
    public DarkMatterVoidStructureGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
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