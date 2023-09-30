using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DarkStarGenerator : BaseGenerator<DarkStar, DarkStarContext>
{
    public DarkStarGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<DarkStar> Generate(DarkStarContext context)
    {
        var result = new DarkStar();
        return result;
    }
}