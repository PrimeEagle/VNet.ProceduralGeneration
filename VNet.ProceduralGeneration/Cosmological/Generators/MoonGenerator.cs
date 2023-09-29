using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class MoonGenerator : BaseGenerator<Moon, MoonContext>
{
    public override Moon Generate(MoonContext context)
    {
        var moon = new Moon();

        return moon;
    }

    public MoonGenerator()
    {
    }
}