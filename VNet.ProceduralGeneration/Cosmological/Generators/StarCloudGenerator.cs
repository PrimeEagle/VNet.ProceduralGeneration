using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarCloudGenerator : GroupGeneratorBase<StarCloud, StarCloudContext>
{
    public StarCloudGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<StarCloud> GenerateSelf(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(StarCloudContext context, StarCloud self)
    {
        throw new NotImplementedException();
    }
}