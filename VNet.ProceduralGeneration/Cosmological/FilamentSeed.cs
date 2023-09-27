using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological;

public class FilamentSeed : Seed
{
    // Example: Special property only relevant to FilamentSeed.
    public float Length { get; set; }

    public FilamentSeed(Vector3 position, float intensity, float length) : base(position, intensity)
    {
        Length = length;
    }

    // Add any methods or additional properties specific to FilamentSeed here.
}