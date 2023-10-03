using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarSystemGenerator : GeneratorBase<StarSystem, StarSystemContext>
{
    public StarSystemGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<StarSystem> GenerateSelf(StarSystemContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StarSystem self, StarSystemContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(StarSystem self, StarSystemContext context)
    {
        throw new NotImplementedException();
    }
}