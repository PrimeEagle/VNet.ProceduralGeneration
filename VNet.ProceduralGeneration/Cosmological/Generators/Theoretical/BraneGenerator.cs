using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class BraneGenerator : GeneratorBase<Brane, BraneContext>
{
    public BraneGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Brane> GenerateSelf(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }
}