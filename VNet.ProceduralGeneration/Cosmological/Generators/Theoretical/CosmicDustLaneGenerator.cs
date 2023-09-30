using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicDustLaneGenerator : BaseGenerator<CosmicDustLane, CosmicDustLaneContext>
{
    public CosmicDustLaneGenerator()
    {
    }

    public async override Task<CosmicDustLane> Generate(CosmicDustLaneContext context)
    {
        var result = new CosmicDustLane();
        return result;
    }
}