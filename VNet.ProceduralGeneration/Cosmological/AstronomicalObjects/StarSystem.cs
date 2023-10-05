namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class StarSystem : AstronomicalObjectContainer
{
    public List<Star> Stars { get; set; } = new();
    public List<Planet> Planets { get; set; } = new();
    public List<IcyCloud> IcyClouds { get; set; } = new();
    public List<AsteroidBelt> AsteroidBelts { get; set; } = new();
}