using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SupernovaRemnantGenerator : BaseGenerator<SupernovaRemnant, SupernovaRemnantContext>
{
    public SupernovaRemnantGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<SupernovaRemnant> GenerateSelf(SupernovaRemnantContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SupernovaRemnant self, SupernovaRemnantContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(SupernovaRemnant self, SupernovaRemnantContext context)
    {
        throw new NotImplementedException();
    }
}