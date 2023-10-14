using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyGroupGenerator : GroupGeneratorBase<GalaxyGroup, GalaxyGroupContext>
{
    public GalaxyGroupGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<GalaxyGroup> GenerateSelf(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }
}