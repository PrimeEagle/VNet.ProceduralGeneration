using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterSheetStructureGenerator : SheetStructureGenerator<DarkMatterSheetStructure, DarkMatterSheetStructureContext>
{
    public DarkMatterSheetStructureGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<DarkMatterSheetStructureGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DarkMatterSheetStructure> GenerateSelf(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(DarkMatterSheetStructureContext context, DarkMatterSheetStructure self)
    {
        throw new NotImplementedException();
    }
}