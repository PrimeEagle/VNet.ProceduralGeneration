using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SuperclusterGenerator : GroupGeneratorBase<Supercluster, SuperclusterContext>
{
    public SuperclusterGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<SuperclusterGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Supercluster> GenerateSelf(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }
}