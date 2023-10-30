using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CuspCatastropheGenerator : GeneratorBase<CuspCatastrophe, CuspCatastropheContext>
{
    public CuspCatastropheGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<CuspCatastropheGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override Task<CuspCatastrophe> GenerateSelf(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }
}