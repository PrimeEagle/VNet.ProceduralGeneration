using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicDustLaneGenerator : BaseGenerator<CosmicDustLane, CosmicDustLaneContext>
{
    public CosmicDustLaneGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<CosmicDustLane> GenerateSelf(CosmicDustLaneContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicDustLane self, CosmicDustLaneContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CosmicDustLane self, CosmicDustLaneContext context)
    {
        throw new NotImplementedException();
    }
}