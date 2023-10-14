using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DebrisDiskGenerator : GroupGeneratorBase<DebrisDisk, DebrisDiskContext>
{
    public DebrisDiskGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<DebrisDisk> GenerateSelf(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }
}