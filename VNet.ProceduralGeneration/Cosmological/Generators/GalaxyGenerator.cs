using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyGenerator : BaseGenerator<Galaxy, GalaxyContext>
{
    public GalaxyGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<Galaxy> GenerateSelf(GalaxyContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Galaxy self, GalaxyContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Galaxy self, GalaxyContext context)
    {
        throw new NotImplementedException();
    }
}