using VNet.ProceduralGeneration.Cosmological.Enum;
// ReSharper disable CollectionNeverQueried.Global

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class Universe : AstronomicalObject
{
    public float DimensionX { get; init; }
    public float DimensionY { get; init; }
    public float DimensionZ { get; init; }
    public double DarkEnergyPercent { get; set; }
    public double DarkMatterPercent { get; set; }
    public double BaryonicMatterPercent { get; set; }
    public CurvatureType Curvature { get; set; }
    public double ConnectivityFactor { get; set; }
    public float CosmicMicrowaveBackground { get; set; }                                        // Kelvin
    public bool InflationOccurred => CalculateInflationOccurred();
    public float CosmicMicrowaveBackgroundVariations => CalculateCmbVariations();               // Kelvin
    public double ExpansionRate => CalculateExpansionRate();                                    // km/s/Mpc
    public double CriticalDensity => CalculateCriticalDensity();                                // kg/AU³
    public CosmicWeb CosmicWeb { get; set; }
    public List<IAstronomicalObject> NonHierarchyObjects { get; init; }




    public Universe()
    {
        this.CosmicWeb = new CosmicWeb();
        this.NonHierarchyObjects = new List<IAstronomicalObject>();
    }

    public Universe(AstronomicalObject parent) : base(parent)
    {
        this.CosmicWeb = new CosmicWeb();
        this.NonHierarchyObjects = new List<IAstronomicalObject>();
    }

    protected override void CalculateVolume()
    {
        volume = DimensionX * DimensionY * DimensionZ;
    }

    private double CalculateCriticalDensity()                                                   // kg/AU³
    {
        return (3 * Math.Pow(1.496e11, 3) * Math.Pow(settings.Advanced.PhysicalConstants.H0 * 2.09e-13, 2))/(8 * Math.PI * settings.Advanced.PhysicalConstants.G);
    }

    private double CalculateExpansionRate()                                                     // kg/s/Mpc
    {
        var OmegaB = BaryonicMatterPercent / 100.0;
        var OmegaDM = DarkMatterPercent / 100.0;
        var OmegaLambda = DarkEnergyPercent / 100.0;

        var H2 =Math.Pow(settings.Advanced.PhysicalConstants.H0, 2) * (OmegaB + OmegaDM + OmegaLambda);

        return Math.Sqrt(H2);
    }

    private float CalculateCmb()                                                                // Kelvin
    {
        return settings.Advanced.PhysicalConstants.BaselineCosmicMicrowaveBackground * (settings.Advanced.PhysicalConstants.BaselineAgeOfUniverse / Age);
    }

    private float CalculateCmbVariations()                                                      // Kelvin
    {
        return Math.Abs(settings.Advanced.PhysicalConstants.BaselineCosmicMicrowaveBackground - CalculateCmb());
    }

    private bool CalculateInflationOccurred()
    {
        return settings.Advanced.Universe.InflationEnd > 0;
    }


    internal override void AssignChildren()
    {
        this.Children.Add(this.CosmicWeb);
    }
}