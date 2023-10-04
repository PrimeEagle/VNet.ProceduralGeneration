using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicDustLaneGenerator : GeneratorBase<CosmicDustLane, CosmicDustLaneContext>
{
    public CosmicDustLaneGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<CosmicDustLane> GenerateSelf(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }
}