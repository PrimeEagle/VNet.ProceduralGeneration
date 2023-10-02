using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CuspCatastropheGenerator : BaseGenerator<CuspCatastrophe, CuspCatastropheContext>
{
    public CuspCatastropheGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<CuspCatastrophe> GenerateSelf(CuspCatastropheContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CuspCatastrophe self, CuspCatastropheContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CuspCatastrophe self, CuspCatastropheContext context)
    {
        throw new NotImplementedException();
    }
}