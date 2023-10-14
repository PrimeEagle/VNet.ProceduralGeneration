using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterFilamentStructureGenerator : FilamentStructureGenerator<BaryonicMatterFilamentStructure, BaryonicMatterFilamentStructureContext>
{
    public BaryonicMatterFilamentStructureGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<BaryonicMatterFilamentStructure> GenerateSelf(BaryonicMatterFilamentStructureContext context, BaryonicMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterFilamentStructureContext context, BaryonicMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(BaryonicMatterFilamentStructureContext context, BaryonicMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(BaryonicMatterFilamentStructureContext context, BaryonicMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(BaryonicMatterFilamentStructureContext context, BaryonicMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(BaryonicMatterFilamentStructureContext context, BaryonicMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(BaryonicMatterFilamentStructureContext context, BaryonicMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }
}