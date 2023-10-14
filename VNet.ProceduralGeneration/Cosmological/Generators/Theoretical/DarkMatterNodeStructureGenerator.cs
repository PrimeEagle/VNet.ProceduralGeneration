using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DarkMatterNodeStructureGenerator : NodeStructureGenerator<DarkMatterNodeStructure, DarkMatterNodeStructureContext>
{
    public DarkMatterNodeStructureGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<DarkMatterNodeStructure> GenerateSelf(DarkMatterNodeStructureContext context, DarkMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterNodeStructureContext context, DarkMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterNodeStructureContext context, DarkMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterNodeStructureContext context, DarkMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(DarkMatterNodeStructureContext context, DarkMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DarkMatterNodeStructureContext context, DarkMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterNodeStructureContext context, DarkMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }
}