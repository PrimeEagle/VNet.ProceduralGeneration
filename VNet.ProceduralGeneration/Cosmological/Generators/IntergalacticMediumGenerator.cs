using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class IntergalacticMediumGenerator : GeneratorBase<IntergalacticMedium, IntergalacticMediumContext>
{
    public IntergalacticMediumGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
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