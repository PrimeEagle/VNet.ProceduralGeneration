using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PreonStarGenerator : BaseGenerator<PreonStar, PreonStarContext>
{
    public PreonStarGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<PreonStar> GenerateSelf(PreonStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PreonStar self, PreonStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PreonStar self, PreonStarContext context)
    {
        throw new NotImplementedException();
    }
}