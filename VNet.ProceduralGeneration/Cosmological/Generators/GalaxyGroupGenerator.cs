using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyGroupGenerator : GeneratorBase<GalaxyGroup, GalaxyGroupContext>
{
    public GalaxyGroupGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<GalaxyGroup> GenerateSelf(GalaxyGroupContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(GalaxyGroup self, GalaxyGroupContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(GalaxyGroup self, GalaxyGroupContext context)
    {
        throw new NotImplementedException();
    }
}