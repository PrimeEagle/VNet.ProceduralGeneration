using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological;

public class NodeSeed : Seed
{
    public float ConnectivityValue { get; set; }

    public NodeSeed(Vector3 position, float intensity) : base(position, intensity)
    {
    }
}