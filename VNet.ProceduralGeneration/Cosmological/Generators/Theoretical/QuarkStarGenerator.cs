using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class QuarkStarGenerator : BaseGenerator<QuarkStar, QuarkStarContext>
{
    public QuarkStarGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<QuarkStar> Generate(QuarkStarContext context)
    {
        var result = new QuarkStar();
        return result;
    }
}