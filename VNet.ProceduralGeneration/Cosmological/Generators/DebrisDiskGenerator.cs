using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DebrisDiskGenerator : GroupGeneratorBase<DebrisDisk, DebrisDiskContext>
{
    public DebrisDiskGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<DebrisDiskGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DebrisDisk> GenerateSelf(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }
}