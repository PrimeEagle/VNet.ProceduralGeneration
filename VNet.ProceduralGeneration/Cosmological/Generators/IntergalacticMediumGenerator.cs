using System.Numerics;
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

    protected override Task<IntergalacticMedium> GenerateSelf(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }
}