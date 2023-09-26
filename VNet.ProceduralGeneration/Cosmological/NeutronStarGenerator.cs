namespace VNet.ProceduralGeneration.Cosmological;

public class NeutronStarGenerator : IGeneratable<NeutronStar, NeutronStarContext>
{
    public NeutronStar Generate(NeutronStarContext context)
    {
        var neutronStar = new NeutronStar
        {

        };

        return neutronStar;
    }
}