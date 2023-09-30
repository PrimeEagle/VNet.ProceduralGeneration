using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicTornadoGenerator : BaseGenerator<CosmicTornado, CosmicTornadoContext>
{
    public CosmicTornadoGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<CosmicTornado> Generate(CosmicTornadoContext context)
    {
        var result = new CosmicTornado();
        return result;
    }
}