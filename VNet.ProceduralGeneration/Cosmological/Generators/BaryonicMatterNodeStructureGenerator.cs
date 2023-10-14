using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterNodeStructureGenerator : NodeStructureGenerator<BaryonicMatterNodeStructure, BaryonicMatterNodeStructureContext>
{
    public BaryonicMatterNodeStructureGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task GenerateChildren(BaryonicMatterNodeStructureContext context, BaryonicMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(BaryonicMatterNodeStructureContext context, BaryonicMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(BaryonicMatterNodeStructureContext context, BaryonicMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override Task<BaryonicMatterNodeStructure> GenerateSelf(BaryonicMatterNodeStructureContext context, BaryonicMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(BaryonicMatterNodeStructureContext context, BaryonicMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(BaryonicMatterNodeStructureContext context, BaryonicMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(BaryonicMatterNodeStructureContext context, BaryonicMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }
}