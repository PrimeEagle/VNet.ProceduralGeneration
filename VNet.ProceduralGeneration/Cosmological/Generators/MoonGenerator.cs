using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class MoonGenerator : BaseGenerator<Moon, MoonContext>
{
    public override async Task<Moon> Generate(MoonContext context)
    {
        var moon = new Moon();

        return moon;
    }

    public MoonGenerator() : base(ParallelismLevel.Level4)
    {
    }
}