using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DarkMatterVoidStructureGenerator : VoidStructureGenerator<DarkMatterVoidStructure, DarkMatterVoidStructureContext>
{
    public DarkMatterVoidStructureGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<DarkMatterVoidStructure> GenerateSelf(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }
}