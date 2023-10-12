using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SuperclusterGenerator : ContainerGeneratorBase<Supercluster, SuperclusterContext>
{
    public SuperclusterGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Supercluster> GenerateSelf(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }
}