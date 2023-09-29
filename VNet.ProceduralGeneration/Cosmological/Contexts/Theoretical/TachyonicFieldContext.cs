namespace VNet.ProceduralGeneration.Cosmological;

public class TachyonicFieldContext : BaseContext
{
    public TachyonicFieldContext()
    {

    }

    public TachyonicFieldContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}