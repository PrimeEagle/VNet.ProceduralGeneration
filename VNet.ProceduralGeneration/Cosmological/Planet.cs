namespace VNet.ProceduralGeneration.Cosmological;

public class Planet : AstronomicalObject
{
    public int Age { get; set; }
    public PlanetType Type { get; set; }
    public double Mass { get; set; }
    public double Radius { get; set; }
    public string Atmosphere { get; set; }
    public TemperatureRange Temperature { get; set; }
    public double RotationPeriod { get; set; }
    public OrbitDetails Orbit { get; set; }
    public List<Moon> Moons { get; set; } = new List<Moon>();
    public SurfaceDetails Surface { get; set; }
    public InteriorDetails Interior { get; set; }
    public MagneticPoles MagneticPoles { get; set; }
    public TectonicActivity TectonicActivity { get; set; }
}