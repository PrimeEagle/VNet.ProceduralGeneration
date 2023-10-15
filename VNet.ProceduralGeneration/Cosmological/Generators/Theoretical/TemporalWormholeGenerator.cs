using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class TemporalWormholeGenerator : GeneratorBase<TemporalWormhole, TemporalWormholeContext>
{
    public TemporalWormholeGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<TemporalWormhole> GenerateSelf(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(TemporalWormholeContext context, TemporalWormhole self)
    {
        throw new NotImplementedException();
    }
}