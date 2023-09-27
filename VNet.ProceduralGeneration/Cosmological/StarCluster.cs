using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological;

public abstract class StarCluster : AstronomicalObject
{
    public ConcurrentBag<StarSystem> StarSystems { get; set; } = new ConcurrentBag<StarSystem>();
    public double Diameter { get; set; }
}