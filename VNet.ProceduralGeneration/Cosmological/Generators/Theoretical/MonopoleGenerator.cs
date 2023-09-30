using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class MonopoleGenerator : BaseGenerator<Monopole, MonopoleContext>
{
    public MonopoleGenerator()
    {
    }

    public async override Task<Monopole> Generate(MonopoleContext context)
    {
        var result = new Monopole();
        return result;
    }
}