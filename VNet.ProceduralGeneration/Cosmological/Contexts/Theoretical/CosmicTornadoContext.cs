namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicTornadoContext : BaseContext
{
    public CosmicTornadoContext()
    {

    }

    public CosmicTornadoContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}