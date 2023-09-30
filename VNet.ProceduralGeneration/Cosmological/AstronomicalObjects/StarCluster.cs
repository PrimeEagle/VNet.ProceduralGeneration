namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class StarCluster : AstronomicalObject
{
    public List<StarSystem> StarSystems { get; set; } = new();
    public double Diameter { get; set; }
}