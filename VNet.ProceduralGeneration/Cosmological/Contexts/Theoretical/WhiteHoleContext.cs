namespace VNet.ProceduralGeneration.Cosmological;

public class WhiteHoleContext : BaseContext
{
    public WhiteHoleContext()
    {

    }

    public WhiteHoleContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}