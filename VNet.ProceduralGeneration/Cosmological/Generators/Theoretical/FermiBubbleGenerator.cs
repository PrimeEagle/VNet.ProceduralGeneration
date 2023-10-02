using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class FermiBubbleGenerator : BaseGenerator<FermiBubble, FermiBubbleContext>
{
    public FermiBubbleGenerator() : base(ParallelismLevel.Level3)
    {
    }

    protected override Task<FermiBubble> GenerateSelf(FermiBubbleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(FermiBubble self, FermiBubbleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(FermiBubble self, FermiBubbleContext context)
    {
        throw new NotImplementedException();
    }
}