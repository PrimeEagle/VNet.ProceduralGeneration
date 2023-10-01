using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NeutronStarGenerator : BaseGenerator<NeutronStar, NeutronStarContext>
{
    public NeutronStarGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<NeutronStar> GenerateSelf(NeutronStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(NeutronStar self, NeutronStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(NeutronStar self, NeutronStarContext context)
    {
        throw new NotImplementedException();
    }
}