using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class TachyonicFieldGenerator : BaseGenerator<TachyonicField, TachyonicFieldContext>
{
    public TachyonicFieldGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override TachyonicField Generate(TachyonicFieldContext context)
    {
        throw new NotImplementedException();
    }
}