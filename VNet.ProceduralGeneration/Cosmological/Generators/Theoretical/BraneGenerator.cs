using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class BraneGenerator : BaseGenerator<Brane, BraneContext>
{
    public BraneGenerator()
    {
    }

    public async override Task<Brane> Generate(BraneContext context)
    {
        var result = new Brane();

        return result;
    }
}