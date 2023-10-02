using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarGenerator : BaseGenerator<Star, StarContext>
{
    public StarGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<Star> GenerateSelf(StarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Star self, StarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Star self, StarContext context)
    {
        throw new NotImplementedException();
    }
}