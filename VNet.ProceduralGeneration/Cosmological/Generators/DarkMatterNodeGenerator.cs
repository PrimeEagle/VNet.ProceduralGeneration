using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterNodeGenerator : BaseGenerator<DarkMatterNode, DarkMatterNodeContext>
{
    public DarkMatterNodeGenerator() : base(ParallelismLevel.Level1)
    {
    }

    protected override Task<DarkMatterNode> GenerateSelf(DarkMatterNodeContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterNode self, DarkMatterNodeContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(DarkMatterNode self, DarkMatterNodeContext context)
    {
        throw new NotImplementedException();
    }
}