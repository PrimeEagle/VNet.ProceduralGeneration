using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicDustLaneGenerator : BaseGenerator<CosmicDustLane, CosmicDustLaneContext>
{
    public CosmicDustLaneGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<CosmicDustLane> Generate(CosmicDustLaneContext context)
    {
        var result = new CosmicDustLane();
        return result;
    }
}