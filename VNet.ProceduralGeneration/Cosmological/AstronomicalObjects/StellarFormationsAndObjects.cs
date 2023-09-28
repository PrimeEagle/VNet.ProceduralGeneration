using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological;

public class StellarFormationsAndObjects : AstronomicalObject
{
    public bool NonClustered { get; set; }
    public bool Clusters { get; set; }
    public ConcurrentBag<Nebula> Nebulae { get; set; } = new ConcurrentBag<Nebula>();
    public ConcurrentBag<Supernova> Supernovae { get; set; } = new ConcurrentBag<Supernova>();
    public BlackHole BlackHole { get; set; }
    public ConcurrentBag<NeutronStar> NeutronStars { get; set; } = new ConcurrentBag<NeutronStar>();
}