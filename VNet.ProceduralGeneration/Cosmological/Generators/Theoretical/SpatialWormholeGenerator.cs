using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class SpatialWormholeGenerator : GeneratorBase<SpatialWormhole, SpatialWormholeContext>
{
    public SpatialWormholeGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<SpatialWormhole> GenerateSelf(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(SpatialWormholeContext context, SpatialWormhole self)
    {
        throw new NotImplementedException();
    }
}