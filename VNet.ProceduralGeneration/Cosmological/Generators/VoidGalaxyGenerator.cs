using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class VoidGalaxyGenerator : ContainerGeneratorBase<VoidGalaxy, VoidGalaxyContext>
{
    public VoidGalaxyGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }

    protected override Task<VoidGalaxy> GenerateSelf(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(VoidGalaxyContext context, VoidGalaxy self)
    {
        throw new NotImplementedException();
    }
}