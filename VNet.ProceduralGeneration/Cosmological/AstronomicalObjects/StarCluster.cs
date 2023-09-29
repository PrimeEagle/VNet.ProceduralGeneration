using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological;

public class StarCluster : AstronomicalObject
{
    public ConcurrentBag<StarSystem> StarSystems { get; set; } = new ConcurrentBag<StarSystem>();
    public double Diameter { get; set; }
}