using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class MoonGenerator : BaseGenerator<Moon, MoonContext>
{
    public async override Task<Moon> Generate(MoonContext context)
    {
        var moon = new Moon();

        return moon;
    }

    public MoonGenerator()
    {
    }
}