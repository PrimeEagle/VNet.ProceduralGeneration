namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class StarCluster : AstronomicalObjectContainer
{
    public List<StarSystem> StarSystems { get; set; } = new();
    public double Diameter { get; set; }
}