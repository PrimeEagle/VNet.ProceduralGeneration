using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterFilamentStructureGenerator : FilamentStructureGenerator<DarkMatterFilamentStructure, DarkMatterFilamentStructureContext>
{
    public DarkMatterFilamentStructureGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<DarkMatterFilamentStructureGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
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

    protected override Task<DarkMatterFilamentStructure> GenerateSelf(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(DarkMatterFilamentStructureContext context, DarkMatterFilamentStructure self)
    {
        throw new NotImplementedException();
    }
}