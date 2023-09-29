using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class StellarNurseryGenerator : BaseGenerator<StellarNursery, StellarNurseryContext>
{
    public override StellarNursery Generate(StellarNurseryContext context)
    {
        var nursery = new StellarNursery
        {

        };

        return nursery;
    }

    public StellarNurseryGenerator(GeneratorConfig config) : base(config)
    {
    }
}