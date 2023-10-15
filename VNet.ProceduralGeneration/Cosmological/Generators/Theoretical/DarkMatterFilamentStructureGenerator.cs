using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DarkMatterFilamentStructureGenerator : FilamentStructureGenerator<DarkMatterFilamentStructure, DarkMatterFilamentStructureContext>
{
    public DarkMatterFilamentStructureGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<DarkMatterFilamentStructure> GenerateSelf(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }
}