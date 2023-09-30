using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterFilamentGenerator : BaseGenerator<BaryonicMatterFilament, BaryonicMatterFilamentContext>
{

    public BaryonicMatterFilamentGenerator() : base(ParallelismLevel.Level1)
    {

    }

    public override async Task<BaryonicMatterFilament> Generate(BaryonicMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }

    private void PostProcess()
    {
    }
}