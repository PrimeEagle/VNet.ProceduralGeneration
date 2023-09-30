using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PrimordialBlackHoleGenerator : BaseGenerator<PrimordialBlackHole, PrimordialBlackHoleContext>
{
    public PrimordialBlackHoleGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<PrimordialBlackHole> Generate(PrimordialBlackHoleContext context)
    {
        var result = new PrimordialBlackHole();
        return result;
    }
}