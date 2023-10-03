using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarGenerator : GeneratorBase<Star, StarContext>
{
    public StarGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Star> GenerateSelf(StarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Star self, StarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Star self, StarContext context)
    {
        throw new NotImplementedException();
    }
}