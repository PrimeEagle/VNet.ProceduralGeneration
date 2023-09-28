namespace VNet.ProceduralGeneration.Cosmological;

public class FuzzballContext : BaseContext
{
    public FuzzballContext()
    {

    }

    public FuzzballContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}