using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NovaGenerator : BaseGenerator<Nova, NovaContext>
{
    public NovaGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<Nova> GenerateSelf(NovaContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Nova self, NovaContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(Nova self, NovaContext context)
    {
        throw new NotImplementedException();
    }
}