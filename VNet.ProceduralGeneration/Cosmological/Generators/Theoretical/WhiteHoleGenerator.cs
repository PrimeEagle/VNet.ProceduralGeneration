using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class WhiteHoleGenerator : GeneratorBase<WhiteHole, WhiteHoleContext>
{
    public WhiteHoleGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<WhiteHole> GenerateSelf(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }
}