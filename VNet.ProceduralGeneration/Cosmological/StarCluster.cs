namespace VNet.ProceduralGeneration.Cosmological;

public abstract class StarCluster : AstronomicalObject
{
    public List<StarSystem> StarSystems { get; set; } = new List<StarSystem>();
    // Common properties for star clusters
    public double Diameter { get; set; }  // Average diameter
}