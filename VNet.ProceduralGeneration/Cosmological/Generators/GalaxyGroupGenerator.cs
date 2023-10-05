using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyGroupGenerator : ContainerGeneratorBase<GalaxyGroup, GalaxyGroupContext>
{
    public GalaxyGroupGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override Task<GalaxyGroup> GenerateSelf(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }
}