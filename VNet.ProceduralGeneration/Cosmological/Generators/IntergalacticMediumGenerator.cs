using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class IntergalacticMediumGenerator : BaseGenerator<IntergalacticMedium, IntergalacticMediumContext>
{
    public override async Task<IntergalacticMedium> Generate(IntergalacticMediumContext context)
    {
        var intergalacticMedium = new IntergalacticMedium
        {

        };


        return intergalacticMedium;
    }

    public IntergalacticMediumGenerator() : base(ParallelismLevel.Level2)
    {
    }
}