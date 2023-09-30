using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BlackHoleGenerator : BaseGenerator<BlackHole, BlackHoleContext>
{
    public override async Task<BlackHole> Generate(BlackHoleContext context)
    {
        var blackHole = new BlackHole
        {

        };

        return blackHole;
    }

    public BlackHoleGenerator() : base(ParallelismLevel.Level4)
    {
    }
}