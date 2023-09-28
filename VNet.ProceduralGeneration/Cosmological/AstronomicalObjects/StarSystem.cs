using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological;

public class StarSystem : AstronomicalObject
{
    public ConcurrentBag<Star> Stars { get; set; } = new ConcurrentBag<Star>();
    public ConcurrentBag<Planet> Planets { get; set; } = new ConcurrentBag<Planet>();
    public ConcurrentBag<IcyPlanet> IcyPlanets { get; set; } = new ConcurrentBag<IcyPlanet>();
    public ConcurrentBag<IcyCloud> IcyClouds { get; set; } = new ConcurrentBag<IcyCloud>();
    public ConcurrentBag<AsteroidBelt> AsteroidBelts { get; set; } = new ConcurrentBag<AsteroidBelt>();
}