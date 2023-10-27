using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PrimordialBlackHoleGenerator : GeneratorBase<PrimordialBlackHole, PrimordialBlackHoleContext>
{
    public PrimordialBlackHoleGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<PrimordialBlackHoleGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task<PrimordialBlackHole> GenerateSelf(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }
}