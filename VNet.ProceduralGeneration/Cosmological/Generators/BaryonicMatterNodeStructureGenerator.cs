using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterNodeStructureGenerator : NodeStructureGenerator<BaryonicMatterNodeStructure, BaryonicMatterNodeStructureContext>
{
    public BaryonicMatterNodeStructureGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
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

    internal override void AssignChildren(BaryonicMatterNodeStructureContext context, BaryonicMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(BaryonicMatterNodeStructureContext context, BaryonicMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }
}