using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class LargeQuasarGroupGenerator : ContainerGeneratorBase<LargeQuasarGroup, LargeQuasarGroupContext>
{
    public LargeQuasarGroupGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override Task<LargeQuasarGroup> GenerateSelf(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }
}