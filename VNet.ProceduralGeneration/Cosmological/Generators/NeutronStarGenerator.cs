using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NeutronStarGenerator : BaseGenerator<NeutronStar, NeutronStarContext>
{
    public override async Task<NeutronStar> Generate(NeutronStarContext context)
    {
        var neutronStar = new NeutronStar
        {

        };

        return neutronStar;
    }

    public NeutronStarGenerator() : base(ParallelismLevel.Level4)
    {
    }
}