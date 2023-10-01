using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class NakedSingularityGenerator : BaseGenerator<NakedSingularity, NakedSingularityContext>
{
    public NakedSingularityGenerator() : base(ParallelismLevel.Level4)
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

    protected override void PostProcess(NakedSingularity self, NakedSingularityContext context)
    {
        throw new NotImplementedException();
    }
}