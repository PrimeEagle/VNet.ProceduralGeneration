namespace VNet.ProceduralGeneration.Cosmological;

public abstract class StarCluster : AstronomicalObject
{
    public List<StarSystem> StarSystems { get; set; } = new List<StarSystem>();
    public double Diameter { get; set; }
}