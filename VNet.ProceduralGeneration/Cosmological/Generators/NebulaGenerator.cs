using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NebulaGenerator : GeneratorBase<Nebula, NebulaContext>
{
    public NebulaGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<NebulaGenerator> loggerService, IAstronomicalObjectCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Nebula> GenerateSelf(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }
}