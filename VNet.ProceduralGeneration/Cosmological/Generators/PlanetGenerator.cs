using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PlanetGenerator : GeneratorBase<Planet, PlanetContext>
{
    public PlanetGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Planet> GenerateSelf(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(PlanetContext context, Planet self)
    {
        throw new NotImplementedException();
    }
}