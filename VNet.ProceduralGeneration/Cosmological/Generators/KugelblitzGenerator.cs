using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class KugelblitzGenerator : GeneratorBase<Kugelblitz, KugelblitzContext>
{
    public KugelblitzGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<KugelblitzGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Kugelblitz> GenerateSelf(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }
}