namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class Supercluster : AstronomicalObjectContainer
{
    public List<GalaxyCluster> GalaxyClusters { get; set; } = new();
}