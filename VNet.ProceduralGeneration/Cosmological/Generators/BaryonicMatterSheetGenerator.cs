using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterSheetGenerator : SheetGeneratorBase<BaryonicMatterSheet, BaryonicMatterSheetContext>
{
    public BaryonicMatterSheetGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<BaryonicMatterSheetGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Task<BaryonicMatterSheet> GenerateSelf(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }
}