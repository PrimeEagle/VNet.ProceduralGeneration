using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class KugelblitzGenerator : BaseGenerator<Kugelblitz, KugelblitzContext>
{
    public KugelblitzGenerator()
    {
    }

    public async override Task<Kugelblitz> Generate(KugelblitzContext context)
    {
        var result = new Kugelblitz();
        return result;
    }
}