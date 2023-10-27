using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class MonopoleContext : ContextBase
{
    public MonopoleContext()
    {
    }

    public MonopoleContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties(cosmicWeb);
    }
}