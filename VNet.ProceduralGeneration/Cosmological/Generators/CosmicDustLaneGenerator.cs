using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CosmicDustLaneGenerator : GeneratorBase<CosmicDustLane, CosmicDustLaneContext>
{
    public CosmicDustLaneGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
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

    protected override void SetMatterType(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CosmicDustLaneContext context, CosmicDustLane self)
    {
        throw new NotImplementedException();
    }
}