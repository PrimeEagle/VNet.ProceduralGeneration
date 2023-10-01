using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class Universe : AstronomicalObject
{
    private const double H0 = 70;                                                   // Present value of Hubble constant in km/s/Mpc (an approximate value for simplicity)
    private const double T0 = 2.725;                                                // Present CMB temperature in Kelvin
    private const double A0 = 13.8e9;                                               // Approximate current age of the universe in years
    private const double CmbThreshold = 0.001;                                      // Arbitrarily chosen threshold. Adjust as needed. Temperature in Kelvin
    private const double InflationStart = 0;                                        // start of inflation in years (essentially 0 for our purposes)
    private const double InflationEnd = 1e-32;                                      // end of inflation in years (an estimate, adjust as needed)


    public double DarkEnergyPercent { get; set; }
    public double DarkMatterPercent { get; set; }
    public double BaryonicMatterPercent { get; set; }

    public CurvatureType Curvature { get; set; }
    public double ConnectivityFactor { get; set; }

    public bool CosmicInflationOccurred { get; set; }
    public CosmicWeb CosmicWeb { get; set; }


    // calculated properties
    public bool CmbHasVariations => CalculateCmbVariations();

    public double ExpansionRate => CalculateExpansionRate();                                // km/s/Mpc
    public double CosmicMicrowaveBackground => CalculateCmb();                              // temperature Kelvin
    public bool IsInInflationPhase => Age >= InflationStart && Age <= InflationEnd;
    public List<IAstronomicalObject> NonhierarchyObjects { get; init; }




    public Universe()
    {
        this.NonhierarchyObjects = new List<IAstronomicalObject>();
    }

    public Universe(IAstronomicalObject parent) : base(parent)
    {
        this.NonhierarchyObjects = new List<IAstronomicalObject>();
    }

    private double CalculateExpansionRate()
    {
        var omegaDe = DarkEnergyPercent / 100.0;
        var omegaDm = DarkMatterPercent / 100.0;
        var omegaB = BaryonicMatterPercent / 100.0;

        return H0 * Math.Sqrt(omegaDe + omegaDm + omegaB);
    }

    private double CalculateCmb()
    {
        return T0 * (A0 / Age);
    }

    private bool CalculateCmbVariations()
    {
        return Math.Abs(T0 - CalculateCmb()) > CmbThreshold;
    }

    public void ApplyInflationEffects()
    {
        if (CosmicInflationOccurred)
        {
            Curvature = CurvatureType.Flat;
        }
    }
}