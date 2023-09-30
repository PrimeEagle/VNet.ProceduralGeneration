namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class GalaxyCluster : AstronomicalObject
{
    public List<Galaxy> Galaxies { get; set; } = new();
    public bool ContainsDarkMatter { get; set; }
}