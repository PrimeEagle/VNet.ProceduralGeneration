using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class FermiBubbleGenerator : BaseGenerator<FermiBubble, FermiBubbleContext>
{
    public FermiBubbleGenerator()
    {
    }

    public async override Task<FermiBubble> Generate(FermiBubbleContext context)
    {
        var result = new FermiBubble();
        return result;
    }
}