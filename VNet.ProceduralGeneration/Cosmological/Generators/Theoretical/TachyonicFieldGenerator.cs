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

    protected override float CalculateAge(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }
}