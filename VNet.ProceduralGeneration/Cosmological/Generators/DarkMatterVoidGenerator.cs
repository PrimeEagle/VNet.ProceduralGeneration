using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterVoidGenerator : BaseGenerator<DarkMatterVoid, DarkMatterVoidContext>
{
    public DarkMatterVoidGenerator() : base(ParallelismLevel.Level1)
    {
    }

    public override async Task<DarkMatterVoid> Generate(DarkMatterVoidContext context)
    {
        throw new NotImplementedException();
    }
}