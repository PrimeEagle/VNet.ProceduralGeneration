using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterVoidGenerator : BaseGenerator<BaryonicMatterVoid, BaryonicMatterVoidContext>
{
    public BaryonicMatterVoidGenerator() : base(ParallelismLevel.Level1)
    {
    }

    public override async Task<BaryonicMatterVoid> Generate(BaryonicMatterVoidContext context)
    {
        throw new NotImplementedException();
    }
}