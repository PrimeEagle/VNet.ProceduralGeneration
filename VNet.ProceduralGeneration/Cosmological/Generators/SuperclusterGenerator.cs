using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SuperclusterGenerator : GeneratorBase<Supercluster, SuperclusterContext>
{
    public SuperclusterGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Supercluster> GenerateSelf(SuperclusterContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Supercluster self, SuperclusterContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Supercluster self, SuperclusterContext context)
    {
        throw new NotImplementedException();
    }
}