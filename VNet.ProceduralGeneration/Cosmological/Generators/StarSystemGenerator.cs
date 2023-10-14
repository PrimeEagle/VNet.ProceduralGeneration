using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarSystemGenerator : GroupGeneratorBase<StarSystem, StarSystemContext>
{
    public StarSystemGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<StarSystem> GenerateSelf(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }
}