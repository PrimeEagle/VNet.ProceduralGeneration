using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BlackHoleGenerator : BaseGenerator<BlackHole, BlackHoleContext>
{
    public BlackHoleGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<BlackHole> GenerateSelf(BlackHoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BlackHole self, BlackHoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(BlackHole self, BlackHoleContext context)
    {
        throw new NotImplementedException();
    }
}