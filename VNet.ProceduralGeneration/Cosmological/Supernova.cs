namespace VNet.ProceduralGeneration.Cosmological;

public class Supernova : Star
{
    public SupernovaType Type { get; set; }
    public double EnergyReleased { get; set; }
    public double Luminosity { get; set; }
    // Other properties specific to Supernovae can be added here.


}