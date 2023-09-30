using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class NakedSingularityGenerator : BaseGenerator<NakedSingularity, NakedSingularityContext>
{
    public NakedSingularityGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<NakedSingularity> Generate(NakedSingularityContext context)
    {
        var result = new NakedSingularity();
        return result;
    }
}