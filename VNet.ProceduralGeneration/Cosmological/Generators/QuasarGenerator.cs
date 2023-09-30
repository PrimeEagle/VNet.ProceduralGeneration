using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class QuasarGenerator : BaseGenerator<Quasar, QuasarContext>
{
    public async override Task<Quasar> Generate(QuasarContext context)
    {
    }

    public QuasarGenerator()
    {
    }
}