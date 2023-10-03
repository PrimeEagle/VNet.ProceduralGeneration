using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class LargeQuasarGroupGenerator : GeneratorBase<LargeQuasarGroup, LargeQuasarGroupContext>
{
    public LargeQuasarGroupGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<LargeQuasarGroup> GenerateSelf(LargeQuasarGroupContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(LargeQuasarGroup self, LargeQuasarGroupContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(LargeQuasarGroup self, LargeQuasarGroupContext context)
    {
        throw new NotImplementedException();
    }
}