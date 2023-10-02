using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicTopologicalDefectGenerator : BaseGenerator<CosmicTopologicalDefect, CosmicTopologicalDefectContext>
{
    public CosmicTopologicalDefectGenerator() : base(ParallelismLevel.Level4)
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