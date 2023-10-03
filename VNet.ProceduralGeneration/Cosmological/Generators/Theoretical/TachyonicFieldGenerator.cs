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

    protected override Task<TachyonicField> GenerateSelf(TachyonicFieldContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(TachyonicField self, TachyonicFieldContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(TachyonicField self, TachyonicFieldContext context)
    {
        throw new NotImplementedException();
    }
}