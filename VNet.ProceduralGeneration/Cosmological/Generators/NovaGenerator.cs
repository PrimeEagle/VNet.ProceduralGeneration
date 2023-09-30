using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class NovaGenerator : BaseGenerator<Nova, NovaContext>
{
    public async override Task<Nova> Generate(NovaContext context)
    {
        var nova = new Nova
        {

        };

        return nova;
    }

    public NovaGenerator()
    {
    }
}