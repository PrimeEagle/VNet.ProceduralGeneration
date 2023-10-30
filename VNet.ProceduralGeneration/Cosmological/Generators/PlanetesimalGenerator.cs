using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PlanetesimalGenerator : GeneratorBase<Planetesimal, PlanetesimalContext>
{
    public PlanetesimalGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<PlanetesimalGenerator> loggerService, IAstronomicalObjectCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(PlanetesimalContext context, Planetesimal self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Planetesimal> GenerateSelf(PlanetesimalContext context, Planetesimal self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PlanetesimalContext context, Planetesimal self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(PlanetesimalContext context, Planetesimal self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(PlanetesimalContext context, Planetesimal self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(PlanetesimalContext context, Planetesimal self)
    {
        throw new NotImplementedException();
    }
}