using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GammaRayBurstGenerator : GeneratorBase<GammaRayBurst, GammaRayBurstContext>
{
    public GammaRayBurstGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override Task<GammaRayBurst> GenerateSelf(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }
}