using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class JumboGenerator : GeneratorBase<Jumbo, JumboContext>
{
    public JumboGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Jumbo> GenerateSelf(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }
}