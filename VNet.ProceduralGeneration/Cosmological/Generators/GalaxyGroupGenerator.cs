using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyGroupGenerator : ContainerGeneratorBase<GalaxyGroup, GalaxyGroupContext>
{
    public GalaxyGroupGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
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

    protected override Task PostProcess(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(GalaxyGroupContext context, GalaxyGroup self)
    {
        throw new NotImplementedException();
    }
}