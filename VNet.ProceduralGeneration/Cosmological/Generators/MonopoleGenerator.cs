using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class MonopoleGenerator : GeneratorBase<Monopole, MonopoleContext>
{
    public MonopoleGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Monopole> GenerateSelf(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }
}