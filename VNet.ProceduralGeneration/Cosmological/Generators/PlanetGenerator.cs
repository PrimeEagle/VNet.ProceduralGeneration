using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PlanetGenerator : GeneratorBase<Planet, PlanetContext>
{
    public PlanetGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Planet> GenerateSelf(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }
}