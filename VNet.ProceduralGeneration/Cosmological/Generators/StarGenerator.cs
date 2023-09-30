using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarGenerator : BaseGenerator<Star, StarContext>
{
    public override async Task<Star> Generate(StarContext context)
    {
        var star = new Star
        {

        };

        return star;
    }

    public StarGenerator() : base(ParallelismLevel.Level4)
    {
    }
}