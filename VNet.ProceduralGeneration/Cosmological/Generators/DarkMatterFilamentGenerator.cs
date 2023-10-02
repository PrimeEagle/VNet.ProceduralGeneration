using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterFilamentGenerator : BaseGenerator<DarkMatterFilament, DarkMatterFilamentContext>
{
    public DarkMatterFilamentGenerator() : base(ParallelismLevel.Level1)
    {
    }

    protected override Task<DarkMatterFilament> GenerateSelf(DarkMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterFilament self, DarkMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkMatterFilament self, DarkMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }
}