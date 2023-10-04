using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class FermiBubbleGenerator : GeneratorBase<FermiBubble, FermiBubbleContext>
{
    public FermiBubbleGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level3)
    {
    }

    protected override Task<FermiBubble> GenerateSelf(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }
}