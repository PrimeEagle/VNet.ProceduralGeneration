using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class FuzzballGenerator : BaseGenerator<Fuzzball, FuzzballContext>
{
    public FuzzballGenerator()
    {
    }

    public async override Task<Fuzzball> Generate(FuzzballContext context)
    {
        var result = new Fuzzball();
        return result;
    }
}