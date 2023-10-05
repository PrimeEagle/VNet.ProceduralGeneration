using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class BaryonicMatterFilament : AstronomicalObjectContainer
{
    public List<Supercluster> Superclusters { get; set; } = new();
    public List<GalaxyCluster> GalaxyClusters { get; set; } = new();
    public List<GalaxyGroup> GalaxyGroups { get; set; } = new();
    public List<Galaxy> Galaxies { get; set; } = new();
    public double Length { get; set; }
    public Vector3 Orientation { get; set; }
}