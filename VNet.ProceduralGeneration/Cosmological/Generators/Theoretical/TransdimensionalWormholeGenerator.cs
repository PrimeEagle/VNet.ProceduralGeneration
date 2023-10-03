using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class TransdimensionalWormholeGenerator : GeneratorBase<TransdimensionalWormhole, TransdimensionalWormholeContext>
{
    public TransdimensionalWormholeGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<TransdimensionalWormhole> GenerateSelf(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(TransdimensionalWormholeContext context, TransdimensionalWormhole self)
    {
        throw new NotImplementedException();
    }
}