using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class SupernovaRemnantGenerator : BaseGenerator<SupernovaRemnant, SupernovaRemnantContext>
{
    public async override Task<SupernovaRemnant> Generate(SupernovaRemnantContext context)
    {
        var remnant = new SupernovaRemnant
        {

        };

        return remnant;
    }

    public SupernovaRemnantGenerator()
    {
    }
}