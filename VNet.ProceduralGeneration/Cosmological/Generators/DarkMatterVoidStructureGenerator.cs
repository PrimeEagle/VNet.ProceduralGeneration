using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterVoidStructureGenerator : VoidStructureGenerator<DarkMatterVoidStructure, DarkMatterVoidStructureContext>
{
    public DarkMatterVoidStructureGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<DarkMatterVoidStructureGenerator> loggerService, IAstronomicalObjectCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
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

    protected override Task<DarkMatterVoidStructure> GenerateSelf(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }
}