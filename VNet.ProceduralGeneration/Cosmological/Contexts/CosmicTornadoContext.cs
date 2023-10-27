using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class CosmicTornadoContext : ContextBase
{
    public CosmicTornadoContext()
    {
    }

    public CosmicTornadoContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties(cosmicWeb);
    }
}