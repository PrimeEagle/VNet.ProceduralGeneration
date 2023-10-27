using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterSheetGenerator : SheetGeneratorBase<DarkMatterSheet, DarkMatterSheetContext>
{
    public DarkMatterSheetGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<DarkMatterSheetGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DarkMatterSheet> GenerateSelf(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }
}