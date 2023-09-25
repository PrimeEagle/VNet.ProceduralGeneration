namespace VNet.ProceduralGeneration.Cosmological;

public class Nebula
{
    public NebulaType Type { get; set; }
    public double Size { get; set; }
    public double Density { get; set; }
    // Other properties specific to Nebulae can be added here.

    public enum NebulaType
    {
        MolecularCloud,
        HIIRegion,
        SupernovaRemnant
    }
}