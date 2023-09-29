using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class SupernovaRemnantGenerator : BaseGenerator<SupernovaRemnant, SupernovaRemnantContext>
{
    public override SupernovaRemnant Generate(SupernovaRemnantContext context)
    {
        var remnant = new SupernovaRemnant
        {

        };

        return remnant;
    }

    public SupernovaRemnantGenerator(GeneratorConfig config) : base(config)
    {
    }
}