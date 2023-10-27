using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class TemporalWormholeGenerator : GeneratorBase<TemporalWormhole, TemporalWormholeContext>
{
    public TemporalWormholeGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task<TemporalWormhole> GenerateSelf(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }
}