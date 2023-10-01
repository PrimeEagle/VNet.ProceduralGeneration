using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class KugelblitzGenerator : BaseGenerator<Kugelblitz, KugelblitzContext>
{
    public KugelblitzGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<Kugelblitz> GenerateSelf(KugelblitzContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Kugelblitz self, KugelblitzContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(Kugelblitz self, KugelblitzContext context)
    {
        throw new NotImplementedException();
    }
}