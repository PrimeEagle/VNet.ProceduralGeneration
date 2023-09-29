using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class BaryonicMatterNodeGenerator : BaseGenerator<BaryonicMatterNode, BaryonicMatterNodeContext>
{
    public BaryonicMatterNodeGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override BaryonicMatterNode Generate(BaryonicMatterNodeContext context)
    {
        throw new NotImplementedException();
    }
}