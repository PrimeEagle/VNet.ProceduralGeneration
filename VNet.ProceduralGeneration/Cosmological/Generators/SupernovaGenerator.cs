using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class SupernovaGenerator : BaseGenerator<Supernova, SupernovaContext>
{
    public async override Task<Supernova> Generate(SupernovaContext context)
    {
        var supernova = new Supernova
        {

        };

        return supernova;
    }

    public SupernovaGenerator()
    {
    }
}