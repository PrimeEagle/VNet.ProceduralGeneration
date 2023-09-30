using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SupernovaRemnantGenerator : BaseGenerator<SupernovaRemnant, SupernovaRemnantContext>
{
    public override async Task<SupernovaRemnant> Generate(SupernovaRemnantContext context)
    {
        var remnant = new SupernovaRemnant
        {

        };

        return remnant;
    }

    public SupernovaRemnantGenerator() : base(ParallelismLevel.Level4)
    {
    }
}