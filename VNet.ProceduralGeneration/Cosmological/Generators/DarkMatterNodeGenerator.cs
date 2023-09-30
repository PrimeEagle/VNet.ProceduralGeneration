using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterNodeGenerator : BaseGenerator<DarkMatterNode, DarkMatterNodeContext>
{
    public DarkMatterNodeGenerator() : base(ParallelismLevel.Level1)
    {
    }

    public override async Task<DarkMatterNode> Generate(DarkMatterNodeContext context)
    {
        throw new NotImplementedException();
    }
}