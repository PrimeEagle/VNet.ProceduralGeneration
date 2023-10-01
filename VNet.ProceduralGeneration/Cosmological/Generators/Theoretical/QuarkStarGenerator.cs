using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class QuarkStarGenerator : BaseGenerator<QuarkStar, QuarkStarContext>
{
    public QuarkStarGenerator() : base(ParallelismLevel.Level4)
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

    protected override void PostProcess(QuarkStar self, QuarkStarContext context)
    {
        throw new NotImplementedException();
    }
}