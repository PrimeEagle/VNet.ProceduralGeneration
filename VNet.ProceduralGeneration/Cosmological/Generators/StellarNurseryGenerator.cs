using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StellarNurseryGenerator : BaseGenerator<StellarNursery, StellarNurseryContext>
{
    public override async Task<StellarNursery> Generate(StellarNurseryContext context)
    {
        var nursery = new StellarNursery
        {

        };

        return nursery;
    }

    public StellarNurseryGenerator() : base(ParallelismLevel.Level4)
    {
    }
}