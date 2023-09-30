using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class Nebula : AstronomicalObject
{
    public NebulaType Type { get; set; }
    public double Size { get; set; }
    public double Density { get; set; }
}