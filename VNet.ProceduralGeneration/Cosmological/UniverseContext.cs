namespace VNet.ProceduralGeneration.Cosmological;

public class UniverseContext : BaseContext
{
    public double CosmicMicrowaveBackground { get; set; }
    public bool CosmicInflation { get; set; }
    public double ExpansionRate { get; set; }
    public double DarkEnergy { get; set; }
    public float Size { get; set; }
    public CurvatureType Curvature { get; set; }
    public BoundednessType Boundedness { get; set; }
    public ConnectivityType Connectivity { get; set; }
}