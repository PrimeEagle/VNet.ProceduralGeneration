using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterNodeGenerator : BaseGenerator<BaryonicMatterNode, BaryonicMatterNodeContext>
{
    public BaryonicMatterNodeGenerator() : base(ParallelismLevel.Level1)
    {
    }

    public override async Task<BaryonicMatterNode> Generate(BaryonicMatterNodeContext context)
    {
        throw new NotImplementedException();
    }
}