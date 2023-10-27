using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NovaGenerator : GeneratorBase<Nova, NovaContext>
{
    public NovaGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Nova> GenerateSelf(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }
}