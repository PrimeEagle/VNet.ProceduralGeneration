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
    public bool CosmicInflationOccurred { get; set; }
    public float CosmicMicrowaveBackground { get; set; }                        // Kelvin
    public float CosmicMicrowaveBackgroundVariations { get; set; }              // Kelvin
    public CosmicWeb CosmicWeb { get; set; }
    public double ExpansionRate => CalculateExpansionRate();                    // km/s/Mpc
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

    private double CalculateExpansionRate()
    {
        double OmegaB = BaryonicMatterPercent / 100.0;
        double OmegaDM = DarkMatterPercent / 100.0;
        double OmegaLambda = DarkEnergyPercent / 100.0;

        double H2 =Math.Pow(settings.Advanced.PhysicalConstants.H0, 2) * (OmegaB + OmegaDM + OmegaLambda);
        return Math.Sqrt(H2);
    }


    private double CalculateCmb()
    {
        return settings.Advanced.PhysicalConstants.BaselineCosmicMicrowaveBackground * (settings.Advanced.PhysicalConstants.BaselineAgeOfUniverse / Age);
    }

    private bool CalculateCmbVariations()
    {
        return Math.Abs(settings.Advanced.PhysicalConstants.BaselineCosmicMicrowaveBackground - CalculateCmb()) > settings.Advanced.Universe.CosmicMicrowaveBackgroundThreshold;
    }

    public void ApplyInflationEffects()
    {
        if (CosmicInflationOccurred)
        {
            Curvature = CurvatureType.Flat;
        }
    }

    internal override void AssignChildren()
    {
        this.Children.Add(this.CosmicWeb);
    }
}