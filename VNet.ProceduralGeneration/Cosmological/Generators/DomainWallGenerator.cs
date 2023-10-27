using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DomainWallGenerator : GeneratorBase<DomainWall, DomainWallContext>
{
    public DomainWallGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<DomainWallGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DomainWall> GenerateSelf(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }
}