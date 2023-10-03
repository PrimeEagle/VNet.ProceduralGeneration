using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AsteroidGenerator : GeneratorBase<Asteroid, AsteroidContext>
{
    public AsteroidGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Asteroid> GenerateSelf(AsteroidContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Asteroid self, AsteroidContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Asteroid self, AsteroidContext context)
    {
        throw new NotImplementedException();
    }
}