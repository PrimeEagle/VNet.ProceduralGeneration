namespace VNet.ProceduralGeneration.Cosmological;

public class Filament : AstronomicalObject
{
    public List<Supercluster> Superclusters { get; set; } = new List<Supercluster>();
    public double Length { get; set; }
}