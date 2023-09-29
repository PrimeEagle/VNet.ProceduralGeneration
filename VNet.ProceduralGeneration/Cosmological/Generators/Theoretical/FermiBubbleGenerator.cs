using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class FermiBubbleGenerator : BaseGenerator<FermiBubble, FermiBubbleContext>
{
    public FermiBubbleGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override FermiBubble Generate(FermiBubbleContext context)
    {
        throw new NotImplementedException();
    }
}