using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;

public class PrimordialBlackHoleContext : BaseContext
{
    public PrimordialBlackHoleContext()
    {

    }

    public PrimordialBlackHoleContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}