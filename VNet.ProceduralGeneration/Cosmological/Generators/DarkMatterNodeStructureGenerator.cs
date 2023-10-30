using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterNodeStructureGenerator : NodeStructureGenerator<DarkMatterNodeStructure, DarkMatterNodeStructureContext>
{
    public DarkMatterNodeStructureGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<DarkMatterNodeStructureGenerator> loggerService, IAstronomicalObjectCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(DarkMatterNodeStructureContext context, DarkMatterNodeStructure self)
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

    protected override Task<DarkMatterNodeStructure> GenerateSelf(DarkMatterNodeStructureContext context, DarkMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterNodeStructureContext context, DarkMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterNodeStructureContext context, DarkMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterNodeStructureContext context, DarkMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DarkMatterNodeStructureContext context, DarkMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(DarkMatterNodeStructureContext context, DarkMatterNodeStructure self)
    {
        throw new NotImplementedException();
    }
}