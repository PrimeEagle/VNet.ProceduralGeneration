using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicTopologicalDefectGenerator : GeneratorBase<CosmicTopologicalDefect, CosmicTopologicalDefectContext>
{
    public CosmicTopologicalDefectGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<CosmicTopologicalDefect> GenerateSelf(CosmicTopologicalDefectContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicTopologicalDefect self, CosmicTopologicalDefectContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CosmicTopologicalDefect self, CosmicTopologicalDefectContext context)
    {
        throw new NotImplementedException();
    }
}