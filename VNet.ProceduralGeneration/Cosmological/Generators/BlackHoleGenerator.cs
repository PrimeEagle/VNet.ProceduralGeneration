using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BlackHoleGenerator : GeneratorBase<BlackHole, BlackHoleContext>
{
    public BlackHoleGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<BlackHole> GenerateSelf(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }
}