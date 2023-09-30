using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological;

public class StarCluster : AstronomicalObject
{
    public List<StarSystem> StarSystems { get; set; } = new List<StarSystem>();
    public double Diameter { get; set; }
}