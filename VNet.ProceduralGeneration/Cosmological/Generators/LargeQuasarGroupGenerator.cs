using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class LargeQuasarGroupGenerator : BaseGenerator<LargeQuasarGroup, LargeQuasarGroupContext>
{
    public override LargeQuasarGroup Generate(LargeQuasarGroupContext context)
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