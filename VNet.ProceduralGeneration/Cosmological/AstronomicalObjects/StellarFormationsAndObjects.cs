using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological;

public class StellarFormationsAndObjects : AstronomicalObject
{
    public bool NonClustered { get; set; }
    public bool Clusters { get; set; }
    public List<Nebula> Nebulae { get; set; } = new List<Nebula>();
    public List<Supernova> Supernovae { get; set; } = new List<Supernova>();
    public BlackHole BlackHole { get; set; }
    public List<NeutronStar> NeutronStars { get; set; } = new List<NeutronStar>();
}