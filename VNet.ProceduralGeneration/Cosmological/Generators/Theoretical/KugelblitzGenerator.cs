using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class KugelblitzGenerator : BaseGenerator<Kugelblitz, KugelblitzContext>
{
    public KugelblitzGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<Kugelblitz> Generate(KugelblitzContext context)
    {
        var result = new Kugelblitz();
        return result;
    }
}