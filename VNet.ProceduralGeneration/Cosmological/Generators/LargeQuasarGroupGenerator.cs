using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class LargeQuasarGroupGenerator : GeneratorBase<LargeQuasarGroup, LargeQuasarGroupContext>
{
    public LargeQuasarGroupGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<LargeQuasarGroup> GenerateSelf(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }
}