using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyClusterGenerator : GeneratorBase<GalaxyCluster, GalaxyClusterContext>
{
    public GalaxyClusterGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<GalaxyCluster> GenerateSelf(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(GalaxyClusterContext context, GalaxyCluster self)
    {
        throw new NotImplementedException();
    }
}