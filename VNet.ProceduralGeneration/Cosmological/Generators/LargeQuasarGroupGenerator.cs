using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class LargeQuasarGroupGenerator : BaseGenerator<LargeQuasarGroup, LargeQuasarGroupContext>
{
    public LargeQuasarGroupGenerator() : base(ParallelismLevel.Level4)
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