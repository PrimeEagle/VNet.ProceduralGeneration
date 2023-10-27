using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class TachyonicFieldGenerator : GeneratorBase<TachyonicField, TachyonicFieldContext>
{
    public TachyonicFieldGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
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

    protected override void SetMatterType(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(TachyonicFieldContext context, TachyonicField self)
    {
        throw new NotImplementedException();
    }
}