using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class FuzzballGenerator : BaseGenerator<Fuzzball, FuzzballContext>
{
    public FuzzballGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<Fuzzball> Generate(FuzzballContext context)
    {
        var result = new Fuzzball();
        return result;
    }
}