using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AsteroidGenerator : GeneratorBase<Asteroid, AsteroidContext>
{
    public AsteroidGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<AsteroidGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Asteroid> GenerateSelf(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(AsteroidContext context, Asteroid self)
    {
        throw new NotImplementedException();
    }
}