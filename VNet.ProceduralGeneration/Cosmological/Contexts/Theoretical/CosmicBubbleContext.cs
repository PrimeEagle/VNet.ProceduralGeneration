namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicBubbleContext : BaseContext
{
    public CosmicBubbleContext()
    {

    }

    public CosmicBubbleContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}