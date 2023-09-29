using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class KugelblitzGenerator : BaseGenerator<Kugelblitz, KugelblitzContext>
{
    public KugelblitzGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override Kugelblitz Generate(KugelblitzContext context)
    {
        throw new NotImplementedException();
    }
}