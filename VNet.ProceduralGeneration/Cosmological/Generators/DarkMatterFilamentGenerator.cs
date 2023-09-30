using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class DarkMatterFilamentGenerator : BaseGenerator<DarkMatterFilament, DarkMatterFilamentContext>
{
    public DarkMatterFilamentGenerator()
    {
    }

    public async override Task<DarkMatterFilament> Generate(DarkMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }
}