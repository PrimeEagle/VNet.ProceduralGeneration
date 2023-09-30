using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class NakedSingularityGenerator : BaseGenerator<NakedSingularity, NakedSingularityContext>
{
    public NakedSingularityGenerator()
    {
    }

    public async override Task<NakedSingularity> Generate(NakedSingularityContext context)
    {
        var result = new NakedSingularity();
        return result;
    }
}