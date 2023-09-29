namespace VNet.ProceduralGeneration.Cosmological;

public class FermiBubbleContext : BaseContext
{
    public FermiBubbleContext()
    {

    }

    public FermiBubbleContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}