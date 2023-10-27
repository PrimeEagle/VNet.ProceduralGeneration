using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CosmicTopologicalDefectGenerator : GeneratorBase<CosmicTopologicalDefect, CosmicTopologicalDefectContext>
{
    public CosmicTopologicalDefectGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<CosmicTopologicalDefectGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override Task<CosmicTopologicalDefect> GenerateSelf(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }
}