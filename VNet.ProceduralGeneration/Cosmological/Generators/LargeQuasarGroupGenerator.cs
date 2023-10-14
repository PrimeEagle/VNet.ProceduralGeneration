using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class LargeQuasarGroupGenerator : GroupGeneratorBase<LargeQuasarGroup, LargeQuasarGroupContext>
{
    public LargeQuasarGroupGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<LargeQuasarGroup> GenerateSelf(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }
}