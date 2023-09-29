using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class BraneGenerator : BaseGenerator<Brane, BraneContext>
{
    public BraneGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override Brane Generate(BraneContext context)
    {
        throw new NotImplementedException();
    }
}