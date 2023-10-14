using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GammaRayBurstGenerator : GeneratorBase<GammaRayBurst, GammaRayBurstContext>
{
    public GammaRayBurstGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<GammaRayBurst> GenerateSelf(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(GammaRayBurstContext context, GammaRayBurst self)
    {
        throw new NotImplementedException();
    }
}