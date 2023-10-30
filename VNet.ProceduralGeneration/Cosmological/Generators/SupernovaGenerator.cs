using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SupernovaGenerator : GeneratorBase<Supernova, SupernovaContext>
{
    public SupernovaGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<SupernovaGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Supernova> GenerateSelf(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }
}