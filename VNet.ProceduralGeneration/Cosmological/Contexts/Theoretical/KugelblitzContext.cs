namespace VNet.ProceduralGeneration.Cosmological;

public class KugelblitzContext : BaseContext
{
    public KugelblitzContext()
    {

    }

    public KugelblitzContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}