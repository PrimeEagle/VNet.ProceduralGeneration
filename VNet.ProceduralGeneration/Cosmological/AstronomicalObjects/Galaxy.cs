using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class Galaxy : AstronomicalObject
{
    public GalaxyType Type { get; set; }
    public bool CentralBlackHole { get; set; }
    public bool Anomalies { get; set; }
    public double StarFormationRate { get; set; }
    public double Metallicity { get; set; }
    public double InterstellarMedium { get; set; }
    public List<StarCluster> StarClusters { get; set; } = new();
}