using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class TachyonicFieldGenerator : BaseGenerator<TachyonicField, TachyonicFieldContext>
{
    public TachyonicFieldGenerator()
    {
    }

    public async override Task<TachyonicField> Generate(TachyonicFieldContext context)
    {
        var result = new TachyonicField();

        return result;
    }
}