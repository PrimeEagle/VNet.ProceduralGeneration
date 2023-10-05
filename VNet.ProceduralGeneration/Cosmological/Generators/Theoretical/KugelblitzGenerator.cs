using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class KugelblitzGenerator : GeneratorBase<Kugelblitz, KugelblitzContext>
{
    public KugelblitzGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Kugelblitz> GenerateSelf(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }
}