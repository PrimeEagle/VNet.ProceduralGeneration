using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological;

public class Planet : AstronomicalObject
{
    public ConcurrentBag<Moon> Moons { get; set; } = new ConcurrentBag<Moon>();
}