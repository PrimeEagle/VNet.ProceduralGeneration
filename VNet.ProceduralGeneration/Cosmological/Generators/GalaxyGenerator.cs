using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyGenerator : BaseGenerator<Galaxy, GalaxyContext>
{
    public override async Task<Galaxy> Generate(GalaxyContext context)
    {
        throw new NotImplementedException();
    }

    public GalaxyGenerator() : base(ParallelismLevel.Level2)
    {
    }
}