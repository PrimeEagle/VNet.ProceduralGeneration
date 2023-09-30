using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicTornadoGenerator : BaseGenerator<CosmicTornado, CosmicTornadoContext>
{
    public CosmicTornadoGenerator()
    {
    }

    public async override Task<CosmicTornado> Generate(CosmicTornadoContext context)
    {
        var result = new CosmicTornado();
        return result;
    }
}