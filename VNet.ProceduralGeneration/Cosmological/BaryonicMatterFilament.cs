using System.Collections.Concurrent;
using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological;

public class BaryonicMatterFilament : AstronomicalObject
{
    public ConcurrentBag<Supercluster> Superclusters { get; set; } = new ConcurrentBag<Supercluster>();
    public ConcurrentBag<GalaxyCluster> GalaxyClusters { get; set; } = new ConcurrentBag<GalaxyCluster>();
    public ConcurrentBag<GalaxyGroup> GalaxyGroups { get; set; } = new ConcurrentBag<GalaxyGroup>();
    public ConcurrentBag<Galaxy> Galaxies { get; set; } = new ConcurrentBag<Galaxy>();
    public double Length { get; set; }
    public Vector3 Orientation { get; set; }
}