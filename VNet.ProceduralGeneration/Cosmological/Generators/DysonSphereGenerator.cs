using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DysonSphereGenerator : GeneratorBase<DysonSphere, DysonSphereContext>
{
    public DysonSphereGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DysonSphere> GenerateSelf(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }
}