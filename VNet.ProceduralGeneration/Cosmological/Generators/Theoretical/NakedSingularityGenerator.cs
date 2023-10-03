using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class NakedSingularityGenerator : GeneratorBase<NakedSingularity, NakedSingularityContext>
{
    public NakedSingularityGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<NakedSingularity> GenerateSelf(NakedSingularityContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(NakedSingularity self, NakedSingularityContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(NakedSingularity self, NakedSingularityContext context)
    {
        throw new NotImplementedException();
    }
}