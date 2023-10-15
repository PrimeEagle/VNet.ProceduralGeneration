using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class IntergalacticMediumGenerator : GeneratorBase<IntergalacticMedium, IntergalacticMediumContext>
{
    public IntergalacticMediumGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<IntergalacticMedium> GenerateSelf(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }
}