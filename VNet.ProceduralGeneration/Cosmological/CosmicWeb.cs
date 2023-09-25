namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicWeb : AstronomicalObject
{
    public IntergalacticMedium IGM { get; set; }
    public double DarkEnergy { get; set; }
    public List<Filament> Filaments { get; set; } = new List<Filament>();  // Composition relationship
}