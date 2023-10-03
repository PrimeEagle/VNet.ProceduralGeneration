using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class KugelblitzGenerator : GeneratorBase<Kugelblitz, KugelblitzContext>
{
    public KugelblitzGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Kugelblitz> GenerateSelf(KugelblitzContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Kugelblitz self, KugelblitzContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Kugelblitz self, KugelblitzContext context)
    {
        throw new NotImplementedException();
    }
}