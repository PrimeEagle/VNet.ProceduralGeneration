using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterFilamentGenerator : BaseGenerator<BaryonicMatterFilament, BaryonicMatterFilamentContext>
{
    public BaryonicMatterFilamentGenerator() : base(ParallelismLevel.Level1)
    {
    }

    protected override Task<BaryonicMatterFilament> GenerateSelf(BaryonicMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterFilament self, BaryonicMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(BaryonicMatterFilament self, BaryonicMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }
}