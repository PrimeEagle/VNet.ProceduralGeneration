using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological;

public class Supercluster : AstronomicalObject
{
    public ConcurrentBag<GalaxyCluster> GalaxyClusters { get; set; } = new ConcurrentBag<GalaxyCluster>();
}