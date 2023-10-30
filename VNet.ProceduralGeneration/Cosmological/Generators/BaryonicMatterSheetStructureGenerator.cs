using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterSheetStructureGenerator : SheetStructureGenerator<BaryonicMatterSheetStructure, BaryonicMatterSheetStructureContext>

{
    public BaryonicMatterSheetStructureGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<BaryonicMatterSheetStructureGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override Task<BaryonicMatterSheetStructure> GenerateSelf(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(BaryonicMatterSheetStructureContext context, BaryonicMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }
}