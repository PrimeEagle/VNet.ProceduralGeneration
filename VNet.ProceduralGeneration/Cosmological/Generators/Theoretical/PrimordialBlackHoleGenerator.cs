using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class PrimordialBlackHoleGenerator : BaseGenerator<PrimordialBlackHole, PrimordialBlackHoleContext>
{
    public PrimordialBlackHoleGenerator()
    {
    }

    public async override Task<PrimordialBlackHole> Generate(PrimordialBlackHoleContext context)
    {
        var result = new PrimordialBlackHole();
        return result;
    }
}