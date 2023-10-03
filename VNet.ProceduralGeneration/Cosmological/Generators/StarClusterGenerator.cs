﻿using System.Numerics;
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

    protected override float CalculateAge(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(StarClusterContext context, StarCluster self)
    {
        throw new NotImplementedException();
    }
}