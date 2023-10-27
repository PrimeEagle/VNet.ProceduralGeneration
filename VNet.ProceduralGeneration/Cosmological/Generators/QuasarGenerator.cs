using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class QuasarGenerator : GeneratorBase<Quasar, QuasarContext>
{
    public QuasarGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Quasar> GenerateSelf(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }
}