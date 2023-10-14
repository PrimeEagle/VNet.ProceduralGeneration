using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyGenerator : GroupGeneratorBase<Galaxy, GalaxyContext>
{
    public GalaxyGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Galaxy> GenerateSelf(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }
}