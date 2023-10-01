using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class MoonGenerator : BaseGenerator<Moon, MoonContext>
{
    public MoonGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<Moon> GenerateSelf(MoonContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Moon self, MoonContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(Moon self, MoonContext context)
    {
        throw new NotImplementedException();
    }
}