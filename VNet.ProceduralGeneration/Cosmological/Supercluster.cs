namespace VNet.ProceduralGeneration.Cosmological;

public class Supercluster : AstronomicalObject
{
    public List<GalaxyCluster> GalaxyClusters { get; set; } = new List<GalaxyCluster>();
}