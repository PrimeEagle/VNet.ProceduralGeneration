using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterFilamentGenerator : BaseGenerator<DarkMatterFilament, DarkMatterFilamentContext>
{
    public DarkMatterFilamentGenerator() : base(ParallelismLevel.Level1)
    {
    }

    public override async Task<DarkMatterFilament> Generate(DarkMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }
}