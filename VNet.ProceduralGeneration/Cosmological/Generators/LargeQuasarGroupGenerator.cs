using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class LargeQuasarGroupGenerator : BaseGenerator<LargeQuasarGroup, LargeQuasarGroupContext>
{
    public override async Task<LargeQuasarGroup> Generate(LargeQuasarGroupContext context)
    {
        var largeQuasarGroup = new LargeQuasarGroup
        {

        };


        return largeQuasarGroup;
    }

    public LargeQuasarGroupGenerator() : base(ParallelismLevel.Level3)
    {
    }
}