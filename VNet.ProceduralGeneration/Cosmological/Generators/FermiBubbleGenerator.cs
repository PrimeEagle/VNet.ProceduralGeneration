using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class FermiBubbleGenerator : GeneratorBase<FermiBubble, FermiBubbleContext>
{
    public FermiBubbleGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<FermiBubbleGenerator> loggerService, IAstronomicalObjectCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override Task<FermiBubble> GenerateSelf(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }
}