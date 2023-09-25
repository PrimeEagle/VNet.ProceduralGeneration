namespace VNet.ProceduralGeneration.Cosmological;

public class NeutronStarGenerator : IGeneratable<NeutronStar, NeutronStarContext>
{
    public NeutronStar Generate(NeutronStarContext context)
    {
        var neutronStar = new NeutronStar
        {
            // ... Generate properties specific to Neutron Star
        };
        return neutronStar;
    }
}