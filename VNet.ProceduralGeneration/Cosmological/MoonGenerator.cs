namespace VNet.ProceduralGeneration.Cosmological;

public class MoonGenerator : IGeneratable<Moon, MoonContext>
{
    public Moon Generate(MoonContext context)
    {
        var moon = new Moon();

        return moon;
    }
}