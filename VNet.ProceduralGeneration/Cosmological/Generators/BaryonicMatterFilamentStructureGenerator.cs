using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterFilamentStructureGenerator : FilamentStructureGenerator<BaryonicMatterFilamentStructure, BaryonicMatterFilamentStructureContext>
{
    public BaryonicMatterFilamentStructureGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<BaryonicMatterFilamentStructureGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(BaryonicMatterFilamentStructureContext context, BaryonicMatterFilamentStructure self)
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

    protected override Task<BaryonicMatterFilamentStructure> GenerateSelf(BaryonicMatterFilamentStructureContext context, BaryonicMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(BaryonicMatterFilamentStructureContext context, BaryonicMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(BaryonicMatterFilamentStructureContext context, BaryonicMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(BaryonicMatterFilamentStructureContext context, BaryonicMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(BaryonicMatterFilamentStructureContext context, BaryonicMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(BaryonicMatterFilamentStructureContext context, BaryonicMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }
}