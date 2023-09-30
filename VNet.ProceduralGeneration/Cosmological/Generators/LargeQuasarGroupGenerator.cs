using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class LargeQuasarGroupGenerator : BaseGenerator<LargeQuasarGroup, LargeQuasarGroupContext>
{
    public async override Task<LargeQuasarGroup> Generate(LargeQuasarGroupContext context)
    {
        var largeQuasarGroup = new LargeQuasarGroup
        {

        };


        return largeQuasarGroup;
    }

    public LargeQuasarGroupGenerator()
    {
    }
}