using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;

public class PrimordialBlackHoleContext : ContextBase
{
    public PrimordialBlackHoleContext()
    {

    }

    public PrimordialBlackHoleContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}