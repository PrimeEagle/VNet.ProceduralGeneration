using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

public interface IAstronomicalObject : IUndefinedAstronomicalObject
{
    public string Id { get; init; }
    public float Age { get; set; } // years
    public float Lifespan { get; set; } // years
    public float Diameter { get; set; } // AU
    public float Temperature { get; set; } // Kelvin
    public float Luminosity { get; set; } // L⊙
    public Vector3 Orientation { get; set; }


    // calculated properties
    public AstronomicalObject? Parent { get; set; }
    public Universe Universe { get; }


    public float EstimateMemorySize();
    public void UpdateBoundingBox();
}