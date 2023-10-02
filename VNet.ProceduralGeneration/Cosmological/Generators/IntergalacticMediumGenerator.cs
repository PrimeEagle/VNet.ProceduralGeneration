using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class IntergalacticMediumGenerator : BaseGenerator<IntergalacticMedium, IntergalacticMediumContext>
{
    public IntergalacticMediumGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<IntergalacticMedium> GenerateSelf(IntergalacticMediumContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(IntergalacticMedium self, IntergalacticMediumContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(IntergalacticMedium self, IntergalacticMediumContext context)
    {
        throw new NotImplementedException();
    }
}