using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class PlanetGenerator : BaseGenerator<Planet, PlanetContext>
{

    public override async Task<Planet> Generate(PlanetContext context)
    {
        throw new NotImplementedException();
    }

    public PlanetGenerator() : base(ParallelismLevel.Level4)
    {
    }
}