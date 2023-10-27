using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class TransdimensionalWormholeGenerator : GeneratorBase<TransdimensionalWormhole, TransdimensionalWormholeContext>
{
    public TransdimensionalWormholeGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task<TransdimensionalWormhole> GenerateSelf(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }
}