using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyGenerator : GeneratorBase<Galaxy, GalaxyContext>
{
    public GalaxyGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Galaxy> GenerateSelf(GalaxyContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Galaxy self, GalaxyContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Galaxy self, GalaxyContext context)
    {
        throw new NotImplementedException();
    }
}