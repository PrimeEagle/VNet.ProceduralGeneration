using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SupernovaGenerator : BaseGenerator<Supernova, SupernovaContext>
{
    public SupernovaGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<Supernova> GenerateSelf(SupernovaContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Supernova self, SupernovaContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Supernova self, SupernovaContext context)
    {
        throw new NotImplementedException();
    }
}