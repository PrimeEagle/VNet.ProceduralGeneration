using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarCloudGenerator : ContainerGeneratorBase<StarCloud, StarCloudContext>
{
    public StarCloudGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override Task<StarCloud> GenerateSelf(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }
}