using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class IntergalacticMediumGenerator : GeneratorBase<IntergalacticMedium, IntergalacticMediumContext>
{
    public IntergalacticMediumGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
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
}