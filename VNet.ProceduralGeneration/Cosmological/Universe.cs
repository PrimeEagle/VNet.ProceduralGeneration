namespace VNet.ProceduralGeneration.Cosmological;

public class Universe : AstronomicalObject
{
    public BoundednessType Boundedness { get; set; }
    public CurvatureType Curvature { get; set; }
    public ConnectivityType Connectivity { get; set; }
    public double CosmicMicrowaveBackground { get; set; }
    public bool CosmicInflation { get; set; }
    public double ExpansionRate { get; set; }
    public double DarkEnergy { get; set; }
    public float Size { get; set; }
    public CosmicWeb CosmicWeb { get; set; }
}