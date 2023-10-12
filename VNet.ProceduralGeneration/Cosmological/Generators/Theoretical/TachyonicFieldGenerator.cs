using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class TachyonicFieldGenerator : GeneratorBase<TachyonicField, TachyonicFieldContext>
{
    public TachyonicFieldGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override Task<TachyonicField> GenerateSelf(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }
}