using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyGroupGenerator : BaseGenerator<GalaxyGroup, GalaxyGroupContext>
{
    public override async Task<GalaxyGroup> Generate(GalaxyGroupContext context)
    {
        throw new NotImplementedException();
    }

    public GalaxyGroupGenerator() : base(ParallelismLevel.Level2)
    {
    }
}