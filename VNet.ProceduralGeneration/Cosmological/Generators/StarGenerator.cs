using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class StarGenerator : BaseGenerator<Star, StarContext>
{
    public async override Task<Star> Generate(StarContext context)
    {
        var star = new Star
        {

        };

        return star;
    }

    public StarGenerator()
    {
    }
}