using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PlanckStarGenerator : GeneratorBase<PlanckStar, PlanckStarContext>
{
    public PlanckStarGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<PlanckStarGenerator> loggerService, IAstronomicalObjectCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task<PlanckStar> GenerateSelf(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(PlanckStarContext context, PlanckStar self)
    {
        throw new NotImplementedException();
    }
}