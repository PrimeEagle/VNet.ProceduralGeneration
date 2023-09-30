using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicStringGenerator : BaseGenerator<CosmicString, CosmicStringContext>
{
    public CosmicStringGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<CosmicString> Generate(CosmicStringContext context)
    {
        var result = new CosmicString();
        return result;
    }
}