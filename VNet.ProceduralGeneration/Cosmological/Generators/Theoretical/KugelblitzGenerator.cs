using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class KugelblitzGenerator : GeneratorBase<Kugelblitz, KugelblitzContext>
{
    public KugelblitzGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Kugelblitz> GenerateSelf(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }
}