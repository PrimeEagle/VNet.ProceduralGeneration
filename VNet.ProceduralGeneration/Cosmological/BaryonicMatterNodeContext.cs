namespace VNet.ProceduralGeneration.Cosmological;

public class BaryonicMatterNodeContext : BaseContext
{
    public SpatialGrid SpatialGrid { get; set; }


    public BaryonicMatterNodeContext()
    {

    }

    public BaryonicMatterNodeContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}