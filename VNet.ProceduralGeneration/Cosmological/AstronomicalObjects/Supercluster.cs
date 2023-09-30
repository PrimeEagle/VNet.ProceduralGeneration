namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class Supercluster : AstronomicalObject
{
    public List<GalaxyCluster> GalaxyClusters { get; set; } = new();
}