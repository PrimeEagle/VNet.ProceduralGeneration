namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class Planet : AstronomicalObject
{
    public List<Moon> Moons { get; set; } = new();
}