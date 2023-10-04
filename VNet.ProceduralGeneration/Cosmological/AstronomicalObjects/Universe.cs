using VNet.ProceduralGeneration.Cosmological.Enum;
// ReSharper disable CollectionNeverQueried.Global

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class Universe : AstronomicalObject
{
    public double DarkEnergyPercent { get; set; }
    public double DarkMatterPercent { get; set; }
    public double BaryonicMatterPercent { get; set; }
    public CurvatureType Curvature { get; set; }
    public double ConnectivityFactor { get; set; }
    public bool InflationOccurred => CalculateInflationOccurred();
    public float CosmicMicrowaveBackground { get; set; }                                        // Kelvin
    public float CosmicMicrowaveBackgroundVariations => CalculateCmbVariations();               // Kelvin
    public double ExpansionRate => CalculateExpansionRate();                                    // km/s/Mpc
    public double CriticalDensity => CalculateCriticalDensity();                                // kg/AU³
    public override double Mass => CalculateMass();                                             // kg

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

    private double CalculateMass()                                                              // kg
    {
        var pDarkMatter = (this.DarkMatterPercent / 100) * this.CriticalDensity;
        var pBaryonicMatter = (this.BaryonicMatterPercent / 100) * this.CriticalDensity;
        
        return this.Volume * (pDarkMatter + pBaryonicMatter);
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

    public void ApplyInflationEffects()
    {
        if (InflationOccurred)
        {
            Curvature = CurvatureType.Flat;
        }
    }

    internal override void AssignChildren()
    {
        this.Children.Add(this.CosmicWeb);
    }
}