using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological;

public class SheetSeed : Seed
{
    // Example: Special property only relevant to SheetSeed.
    public float Area { get; set; }

    public SheetSeed(Vector3 position, float intensity, float area) : base(position, intensity)
    {
        Area = area;
    }

    // Add any methods or additional properties specific to SheetSeed here.
}