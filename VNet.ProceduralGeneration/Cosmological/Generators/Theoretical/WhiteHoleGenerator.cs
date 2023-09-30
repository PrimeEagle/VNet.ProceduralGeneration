using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class WhiteHoleGenerator : BaseGenerator<WhiteHole, WhiteHoleContext>
{
    public WhiteHoleGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<WhiteHole> Generate(WhiteHoleContext context)
    {
        var result = new WhiteHole();

        return result;
    }
}