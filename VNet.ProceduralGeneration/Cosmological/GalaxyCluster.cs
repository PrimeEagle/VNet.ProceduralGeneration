namespace VNet.ProceduralGeneration.Cosmological;

public class GalaxyCluster : AstronomicalObject
{
    public List<Galaxy> Galaxies { get; set; } = new List<Galaxy>();
    public bool ContainsDarkMatter { get; set; }
    // Other properties specific to galaxy clusters can be added here.
}