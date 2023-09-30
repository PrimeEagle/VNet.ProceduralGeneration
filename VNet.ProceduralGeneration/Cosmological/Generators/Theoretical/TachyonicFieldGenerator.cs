using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class TachyonicFieldGenerator : BaseGenerator<TachyonicField, TachyonicFieldContext>
{
    public TachyonicFieldGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<TachyonicField> Generate(TachyonicFieldContext context)
    {
        var result = new TachyonicField();

        return result;
    }
}