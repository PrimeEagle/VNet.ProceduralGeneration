using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological;

public class VoidSeed : Seed
{
    // Voids might have a size or a measure of how "empty" they are.
    public float VoidSize { get; set; }

    public VoidSeed(Vector3 position, float intensity, float voidSize) : base(position, intensity)
    {
        VoidSize = voidSize;
    }

    // Add any methods or additional properties specific to VoidSeed here.
}