using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class IntergalacticMediumGenerator : BaseGenerator<IntergalacticMedium, IntergalacticMediumContext>
{
    public async override Task<IntergalacticMedium> Generate(IntergalacticMediumContext context)
    {
        var intergalacticMedium = new IntergalacticMedium
        {

        };


        return intergalacticMedium;
    }

    public IntergalacticMediumGenerator()
    {
    }
}