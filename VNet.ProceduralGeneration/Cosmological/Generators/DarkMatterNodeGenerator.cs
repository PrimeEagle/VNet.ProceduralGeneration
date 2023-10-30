using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterNodeGenerator : NodeGeneratorBase<DarkMatterNode, DarkMatterNodeContext>
{
    public DarkMatterNodeGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<DarkMatterNodeGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DarkMatterNode> GenerateSelf(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }
}