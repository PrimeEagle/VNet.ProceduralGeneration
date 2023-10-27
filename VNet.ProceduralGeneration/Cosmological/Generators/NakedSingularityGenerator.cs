using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NakedSingularityGenerator : GeneratorBase<NakedSingularity, NakedSingularityContext>
{
    public NakedSingularityGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override Task<NakedSingularity> GenerateSelf(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }
}