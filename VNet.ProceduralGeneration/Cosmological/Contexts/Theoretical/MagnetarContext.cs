namespace VNet.ProceduralGeneration.Cosmological;

public class MagnetarContext : BaseContext
{
    public MagnetarContext()
    {

    }

    public MagnetarContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}