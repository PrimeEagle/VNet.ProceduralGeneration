using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AsteroidBeltGenerator : GeneratorBase<AsteroidBelt, AsteroidBeltContext>
{
    protected override Task<AsteroidBelt> GenerateSelf(AsteroidBeltContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(AsteroidBelt self, AsteroidBeltContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(AsteroidBelt self, AsteroidBeltContext context)
    {
        throw new NotImplementedException();
    }

    public AsteroidBeltGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }
}