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

    protected override float CalculateAge(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }
}