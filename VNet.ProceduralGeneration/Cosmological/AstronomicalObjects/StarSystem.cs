using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological;

public class StarSystem : AstronomicalObject
{
    public List<Star> Stars { get; set; } = new List<Star>();
    public List<Planet> Planets { get; set; } = new List<Planet>();
    public List<IcyPlanet> IcyPlanets { get; set; } = new List<IcyPlanet>();
    public List<IcyCloud> IcyClouds { get; set; } = new List<IcyCloud>();
    public List<AsteroidBelt> AsteroidBelts { get; set; } = new List<AsteroidBelt>();
}