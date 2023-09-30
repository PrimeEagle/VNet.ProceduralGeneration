using System.Collections.Concurrent;
using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological;

public class BaryonicMatterFilament : AstronomicalObject
{
    public List<Supercluster> Superclusters { get; set; } = new List<Supercluster>();
    public List<GalaxyCluster> GalaxyClusters { get; set; } = new List<GalaxyCluster>();
    public List<GalaxyGroup> GalaxyGroups { get; set; } = new List<GalaxyGroup>();
    public List<Galaxy> Galaxies { get; set; } = new List<Galaxy>();
    public double Length { get; set; }
    public Vector3 Orientation { get; set; }
}