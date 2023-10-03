﻿using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class SpatialWormholeGenerator : GeneratorBase<SpatialWormhole, SpatialWormholeContext>
{
    public SpatialWormholeGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<SpatialWormhole> GenerateSelf(SpatialWormholeContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SpatialWormhole self, SpatialWormholeContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(SpatialWormhole self, SpatialWormholeContext context)
    {
        throw new NotImplementedException();
    }
}