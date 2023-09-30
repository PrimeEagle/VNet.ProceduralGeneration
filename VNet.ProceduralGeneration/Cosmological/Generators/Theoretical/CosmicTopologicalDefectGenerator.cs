using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicTopologicalDefectGenerator : BaseGenerator<CosmicTopologicalDefect, CosmicTopologicalDefectContext>
{
    public CosmicTopologicalDefectGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<CosmicTopologicalDefect> Generate(CosmicTopologicalDefectContext context)
    {
        var result = new CosmicTopologicalDefect();
        return result;
    }
}