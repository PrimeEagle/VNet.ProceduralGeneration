using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PlanetesimalGenerator : GeneratorBase<Planetesimal, PlanetesimalContext>
{
    public PlanetesimalGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Planetesimal> GenerateSelf(PlanetesimalContext context, Planetesimal self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PlanetesimalContext context, Planetesimal self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(PlanetesimalContext context, Planetesimal self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PlanetesimalContext context, Planetesimal self)
    {
        throw new NotImplementedException();
    }
}