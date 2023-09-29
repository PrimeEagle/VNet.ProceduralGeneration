using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class IntergalacticMediumGenerator : BaseGenerator<IntergalacticMedium, IntergalacticMediumContext>
{
    public override IntergalacticMedium Generate(IntergalacticMediumContext context)
    {
        var intergalacticMedium = new IntergalacticMedium
        {

        };


        return intergalacticMedium;
    }

    public IntergalacticMediumGenerator(GeneratorConfig config) : base(config)
    {
    }
}