using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SuperclusterGenerator : GroupGeneratorBase<Supercluster, SuperclusterContext>
{
    public SuperclusterGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Supercluster> GenerateSelf(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }
}