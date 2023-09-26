namespace VNet.ProceduralGeneration.Cosmological;

public class NeutronStarGenerator : BaseGenerator<NeutronStar, NeutronStarContext>
{
    public override NeutronStar Generate(NeutronStarContext context)
    {
        var neutronStar = new NeutronStar
        {

        };

        return neutronStar;
    }

    public NeutronStarGenerator(GeneratorConfig config) : base(config)
    {
    }
}