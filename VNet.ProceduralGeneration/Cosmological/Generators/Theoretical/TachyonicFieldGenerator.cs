using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class TachyonicFieldGenerator : BaseGenerator<TachyonicField, TachyonicFieldContext>
{
    public TachyonicFieldGenerator() : base(ParallelismLevel.Level4)
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

    protected override void PostProcess(TachyonicField self, TachyonicFieldContext context)
    {
        throw new NotImplementedException();
    }
}