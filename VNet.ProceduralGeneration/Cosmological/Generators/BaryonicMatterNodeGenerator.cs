using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterNodeGenerator : BaseGenerator<BaryonicMatterNode, BaryonicMatterNodeContext>
{
    public BaryonicMatterNodeGenerator() : base(ParallelismLevel.Level1)
    {
    }

    protected override Task<BaryonicMatterNode> GenerateSelf(BaryonicMatterNodeContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterNode self, BaryonicMatterNodeContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(BaryonicMatterNode self, BaryonicMatterNodeContext context)
    {
        throw new NotImplementedException();
    }
}