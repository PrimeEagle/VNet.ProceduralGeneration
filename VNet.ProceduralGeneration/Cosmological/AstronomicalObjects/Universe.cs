using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Enum;
#pragma warning disable CS8629 // Nullable value type may be null.

// ReSharper disable CollectionNeverQueried.Global

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class Universe : AstronomicalObjectGroup
{
    private double? _criticalDensity;
    private double? _expansionRate;
    private float? _cmbVariations;
    private bool? _inflationOccurred;



    public Universe()
    {
        CosmicWeb = new CosmicWeb();
        NonHierarchyObjects = new List<IAstronomicalObject>();
    }

    public Universe(AstronomicalObject parent) : base(parent)
    {
        CosmicWeb = new CosmicWeb();
        NonHierarchyObjects = new List<IAstronomicalObject>();
    }

    public float DimensionX { get; init; }
    public float DimensionY { get; init; }
    public float DimensionZ { get; init; }
    public double DarkEnergyPercent { get; set; }
    public double DarkMatterPercent { get; set; }
    public double BaryonicMatterPercent { get; set; }
    public CurvatureType Curvature { get; set; }
    public double ConnectivityFactor { get; set; }
    public CosmicWeb CosmicWeb { get; set; }
    public List<IAstronomicalObject> NonHierarchyObjects { get; init; }
    public float OmegaBaryonicMatter => (float)BaryonicMatterPercent / 100.0f;
    public float OmegaDarkMatter => (float)DarkMatterPercent / 100.0f;
    public float OmegaDarkEnergy => (float)DarkEnergyPercent / 100.0f;
    public float OmegaMatter => OmegaBaryonicMatter + OmegaDarkMatter;
    public float CosmicMicrowaveBackground { get; set; }




    public double CriticalDensity
    {
        get
        {
            if(!_criticalDensity.HasValue) CalculateCriticalDensity();

            return _criticalDensity.Value;
        }
    }

    public double ExpansionRate
    {
        get
        {
            if(!_expansionRate.HasValue) CalculateExpansionRate();

            return _expansionRate.Value;
        }
    }

    public float CosmicMicrowaveBackgroundVariations
    {
        get
        {
            if(!_cmbVariations.HasValue) CalculateCmbVariations();

            return _cmbVariations.Value;
        }
    }

    public bool InflationOccurred
    {
        get
        {
            if(!_inflationOccurred.HasValue) CalculateInflationOccurred();

            return _inflationOccurred.Value;
        }
    }

    protected override void CalculateVolume()
    {
        volume = DimensionX * DimensionY * DimensionZ;
    }

    private void CalculateCriticalDensity() // kg/AU³
    {
        _criticalDensity = 3 * Math.Pow(1.496e11, 3) * Math.Pow(settings.Advanced.PhysicalConstants.H0 * 2.09e-13, 2) / (8 * Math.PI * settings.Advanced.PhysicalConstants.G);
    }

    private void CalculateExpansionRate() // kg/s/Mpc
    {
        var omegaB = BaryonicMatterPercent / 100.0;
        var omegaDm = DarkMatterPercent / 100.0;
        var omegaLambda = DarkEnergyPercent / 100.0;

        var h2 = Math.Pow(settings.Advanced.PhysicalConstants.H0, 2) * (omegaB + omegaDm + omegaLambda);

        _expansionRate = Math.Sqrt(h2);
    }

    private void CalculateCmbVariations() // Kelvin
    {
        _cmbVariations = Math.Abs(settings.Advanced.PhysicalConstants.BaselineCosmicMicrowaveBackground - CosmicMicrowaveBackground);
    }

    private void CalculateInflationOccurred()
    {
        _inflationOccurred = settings.Advanced.Objects.Universe.InflationRange.Start > 0;
    }

    public override void RecalculateProperties()
    {
        base.RecalculateProperties();
        
        CalculateCriticalDensity();
        CalculateExpansionRate();
        CalculateCmbVariations();
        CalculateInflationOccurred();
    }
}