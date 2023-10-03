using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DarkStarGenerator : GeneratorBase<DarkStar, DarkStarContext>
{
    public DarkStarGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<DarkStar> GenerateSelf(DarkStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkStar self, DarkStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkStar self, DarkStarContext context)
    {
        throw new NotImplementedException();
    }
}