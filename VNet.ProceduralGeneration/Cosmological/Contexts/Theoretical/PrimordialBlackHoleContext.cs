namespace VNet.ProceduralGeneration.Cosmological;

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