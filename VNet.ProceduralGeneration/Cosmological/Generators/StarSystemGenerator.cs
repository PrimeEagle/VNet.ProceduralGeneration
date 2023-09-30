using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarSystemGenerator : BaseGenerator<StarSystem, StarSystemContext>
{
    public override async Task<StarSystem> Generate(StarSystemContext context)
    {
        throw new NotImplementedException();
    }

    public StarSystemGenerator() : base(ParallelismLevel.Level3)
    {
    }
}