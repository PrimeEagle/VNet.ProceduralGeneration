using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological;

public class AsteroidBelt : AstronomicalObject
{
    public ConcurrentBag<Asteroid> Asteroids { get; set; } = new ConcurrentBag<Asteroid>();
}