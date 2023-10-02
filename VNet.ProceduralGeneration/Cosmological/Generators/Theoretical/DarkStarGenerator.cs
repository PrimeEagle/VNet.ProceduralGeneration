using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DarkStarGenerator : BaseGenerator<DarkStar, DarkStarContext>
{
    public DarkStarGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<DarkStar> GenerateSelf(DarkStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkStar self, DarkStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkStar self, DarkStarContext context)
    {
        throw new NotImplementedException();
    }
}