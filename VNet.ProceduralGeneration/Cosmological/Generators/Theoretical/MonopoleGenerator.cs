using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class MonopoleGenerator : BaseGenerator<Monopole, MonopoleContext>
{
    public MonopoleGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<Monopole> Generate(MonopoleContext context)
    {
        var result = new Monopole();
        return result;
    }
}