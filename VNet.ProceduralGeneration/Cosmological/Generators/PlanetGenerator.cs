using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PlanetGenerator : GeneratorBase<Planet, PlanetContext>
{
    public PlanetGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Planet> GenerateSelf(PlanetContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Planet self, PlanetContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Planet self, PlanetContext context)
    {
        throw new NotImplementedException();
    }
}