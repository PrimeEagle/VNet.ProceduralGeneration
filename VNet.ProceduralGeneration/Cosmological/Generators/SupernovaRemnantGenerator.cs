using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SupernovaRemnantGenerator : GeneratorBase<SupernovaRemnant, SupernovaRemnantContext>
{
    public SupernovaRemnantGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override Task<SupernovaRemnant> GenerateSelf(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }
}