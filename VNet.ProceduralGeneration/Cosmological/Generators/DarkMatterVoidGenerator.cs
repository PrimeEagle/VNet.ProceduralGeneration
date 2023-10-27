using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterVoidGenerator : VoidGeneratorBase<DarkMatterVoid, DarkMatterVoidContext>
{
    public DarkMatterVoidGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<DarkMatterVoidGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DarkMatterVoid> GenerateSelf(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }
}