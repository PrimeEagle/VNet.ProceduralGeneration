using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class Supernova : Star
{
    public SupernovaType Type { get; set; }
    public double EnergyReleased { get; set; }
    public double Luminosity { get; set; }
}