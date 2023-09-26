namespace VNet.ProceduralGeneration.Cosmological;

public class GalaxyCluster : AstronomicalObject
{
    public List<Galaxy> Galaxies { get; set; } = new List<Galaxy>();
    public bool ContainsDarkMatter { get; set; }
}