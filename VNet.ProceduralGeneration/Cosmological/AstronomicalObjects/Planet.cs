using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological;

public class Planet : AstronomicalObject
{
    public List<Moon> Moons { get; set; } = new List<Moon>();
}