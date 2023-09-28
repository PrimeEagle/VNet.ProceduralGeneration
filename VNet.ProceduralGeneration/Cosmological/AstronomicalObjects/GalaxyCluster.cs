using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological;

public class GalaxyCluster : AstronomicalObject
{
    public ConcurrentBag<Galaxy> Galaxies { get; set; } = new ConcurrentBag<Galaxy>();
    public bool ContainsDarkMatter { get; set; }
}