using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicTopologicalDefectGenerator : BaseGenerator<CosmicTopologicalDefect, CosmicTopologicalDefectContext>
{
    public CosmicTopologicalDefectGenerator()
    {
    }

    public async override Task<CosmicTopologicalDefect> Generate(CosmicTopologicalDefectContext context)
    {
        var result = new CosmicTopologicalDefect();
        return result;
    }
}