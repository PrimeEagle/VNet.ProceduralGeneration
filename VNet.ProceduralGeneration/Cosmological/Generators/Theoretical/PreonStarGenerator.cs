using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PreonStarGenerator : BaseGenerator<PreonStar, PreonStarContext>
{
    public PreonStarGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<PreonStar> Generate(PreonStarContext context)
    {
        var result = new PreonStar();
        return result;
    }
}