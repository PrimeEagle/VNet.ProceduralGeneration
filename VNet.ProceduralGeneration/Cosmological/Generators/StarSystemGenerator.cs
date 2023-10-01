using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarSystemGenerator : BaseGenerator<StarSystem, StarSystemContext>
{
    public StarSystemGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<StarSystem> GenerateSelf(StarSystemContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StarSystem self, StarSystemContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(StarSystem self, StarSystemContext context)
    {
        throw new NotImplementedException();
    }
}