namespace VNet.ProceduralGeneration.Cosmological;

public class DarkMatterNodeContext : BaseContext
{
    public SpatialGrid SpatialGrid { get; set; }


    public DarkMatterNodeContext()
    {

    }

    public DarkMatterNodeContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}