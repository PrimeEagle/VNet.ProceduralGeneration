using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class FermiBubbleGenerator : BaseGenerator<FermiBubble, FermiBubbleContext>
{
    public FermiBubbleGenerator() : base(ParallelismLevel.Level3)
    {
    }

    public override async Task<FermiBubble> Generate(FermiBubbleContext context)
    {
        var result = new FermiBubble();
        return result;
    }
}