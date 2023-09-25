namespace VNet.ProceduralGeneration.Cosmological;

public class Filament : AstronomicalObject
{
    public List<Supercluster> Superclusters { get; set; } = new List<Supercluster>();
    public double Length { get; set; }  // Filaments are long structures.
    // Other properties specific to filaments can be added here.
}