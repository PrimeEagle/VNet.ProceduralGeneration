using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StellarNurseryGenerator : BaseGenerator<StellarNursery, StellarNurseryContext>
{
    public StellarNurseryGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<StellarNursery> GenerateSelf(StellarNurseryContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StellarNursery self, StellarNurseryContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(StellarNursery self, StellarNurseryContext context)
    {
        throw new NotImplementedException();
    }
}