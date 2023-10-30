using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class QuantumBlackHoleGenerator : GeneratorBase<QuantumBlackHole, QuantumBlackHoleContext>
{
    public QuantumBlackHoleGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<QuantumBlackHoleGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task<QuantumBlackHole> GenerateSelf(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }
}