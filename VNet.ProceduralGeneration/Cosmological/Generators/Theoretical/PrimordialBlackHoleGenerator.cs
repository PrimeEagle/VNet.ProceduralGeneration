using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class PrimordialBlackHoleGenerator : BaseGenerator<PrimordialBlackHole, PrimordialBlackHoleContext>
{
    public PrimordialBlackHoleGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override PrimordialBlackHole Generate(PrimordialBlackHoleContext context)
    {
        throw new NotImplementedException();
    }
}