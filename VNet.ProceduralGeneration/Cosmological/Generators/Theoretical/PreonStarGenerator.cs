using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PreonStarGenerator : GeneratorBase<PreonStar, PreonStarContext>
{
    public PreonStarGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<PreonStar> GenerateSelf(PreonStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PreonStar self, PreonStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(PreonStar self, PreonStarContext context)
    {
        throw new NotImplementedException();
    }
}