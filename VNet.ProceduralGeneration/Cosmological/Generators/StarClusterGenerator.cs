using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarClusterGenerator : GeneratorBase<StarCluster, StarClusterContext>
{
    public StarClusterGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<StarCluster> GenerateSelf(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }
}