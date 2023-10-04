using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class TachyonicFieldGenerator : GeneratorBase<TachyonicField, TachyonicFieldContext>
{
    public TachyonicFieldGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<TachyonicField> GenerateSelf(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }
}