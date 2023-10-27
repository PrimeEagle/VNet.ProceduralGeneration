using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SpatialWormholeGenerator : GeneratorBase<SpatialWormhole, SpatialWormholeContext>
{
    public SpatialWormholeGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task<SpatialWormhole> GenerateSelf(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }
}