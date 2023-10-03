using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class QuarkStarGenerator : GeneratorBase<QuarkStar, QuarkStarContext>
{
    public QuarkStarGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<QuarkStar> GenerateSelf(QuarkStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(QuarkStar self, QuarkStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(QuarkStar self, QuarkStarContext context)
    {
        throw new NotImplementedException();
    }
}