using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class MonopoleGenerator : BaseGenerator<Monopole, MonopoleContext>
{
    public MonopoleGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override Monopole Generate(MonopoleContext context)
    {
        throw new NotImplementedException();
    }
}