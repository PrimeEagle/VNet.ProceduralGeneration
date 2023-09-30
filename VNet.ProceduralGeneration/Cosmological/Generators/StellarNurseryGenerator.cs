using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class StellarNurseryGenerator : BaseGenerator<StellarNursery, StellarNurseryContext>
{
    public async override Task<StellarNursery> Generate(StellarNurseryContext context)
    {
        var nursery = new StellarNursery
        {

        };

        return nursery;
    }

    public StellarNurseryGenerator()
    {
    }
}