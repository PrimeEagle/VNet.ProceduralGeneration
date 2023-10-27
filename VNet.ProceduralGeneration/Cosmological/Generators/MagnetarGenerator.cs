using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class MagnetarGenerator : GeneratorBase<Magnetar, MagnetarContext>
{
    public MagnetarGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<MagnetarGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Magnetar> GenerateSelf(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }
}