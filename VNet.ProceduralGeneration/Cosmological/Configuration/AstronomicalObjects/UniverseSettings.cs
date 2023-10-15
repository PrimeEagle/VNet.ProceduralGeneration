using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Mathematics.Randomization.Generation;


namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

public class UniverseSettings : ISettings
{
    [Range(0, float.MaxValue)]
    [DisplayName("Cosmic Microwave Background Threshold")]
    [Tooltip("The threshold for the cosmic microwave background.")]
    public float CosmicMicrowaveBackgroundThreshold { get; init; }

    [Range(0, 100)]
    [PercentageWithProperties(new[] { nameof(CurvatureSphericalPercentage), nameof(CurvatureHyperbolicPercentage) })]
    [DisplayName("Curvature Flat Percentage")]
    [Tooltip("Probability of the curvature of the universe being flat, as a percentage.")]
    public float CurvatureFlatPercentage { get; init; }

    [Range(0, 100)]
    [PercentageWithProperties(new[] { nameof(CurvatureFlatPercentage), nameof(CurvatureSphericalPercentage) })]
    [DisplayName("Curvature Hyperbolic Percentage")]
    [Tooltip("Probability of the curvature of the universe being hyperbolic, as a percentage.")]
    public float CurvatureHyperbolicPercentage { get; init; }

    [Range(0, 100)]
    [PercentageWithProperties(new[] { nameof(CurvatureFlatPercentage), nameof(CurvatureHyperbolicPercentage) })]
    [DisplayName("Curvature Spherical Percentage")]
    [Tooltip("Probability of the curvature of the universe being spherical, as a percentage.")]
    public float CurvatureSphericalPercentage { get; init; }

    [Range(1, 99)]
    [DisplayName("Gaussian Kernel Size")]
    [Tooltip("This value creates an n x n grid and, for each pixel, looks at other pixels contained in the grid to determine the amount of blur to apply.")]
    public int GaussianKernelSize { get; init; }

    [Range(0, float.MaxValue)]
    [DisplayName("Gaussian Sigma")]
    [Tooltip("The amount of gaussian blur to apply to the Heightmap Image File (0 = none).")]
    public float GaussianSigma { get; init; }

    [Range(0, double.MaxValue)]
    [GreaterThanOrEqualToProperty(nameof(InflationStart))]
    [DisplayName("Inflation End")]
    [Tooltip("The end of the inflation stage of the universe. Value = 0 means no inflation.")]
    public double InflationEnd { get; init; }

    [Range(0, double.MaxValue)]
    [LessThanOrEqualToProperty(nameof(InflationEnd))]
    [DisplayName("Inflation Start")]
    [Tooltip("The start of the inflation stage of the universe.")]
    public double InflationStart { get; init; }

    [Range(0, 100)]
    [GreaterThanOrEqualToProperty(nameof(MinConnectivityFactor))]
    [DisplayName("Max Connectivity Factor")]
    [Tooltip("The maximum amount that the universes curves or folds to connect distant locations. Affect amount of wormholes. (0 = none, 100 = max)")]
    public float MaxConnectivityFactor { get; init; }

    [Range(0, 100)]
    [GreaterThanOrEqualToProperty(nameof(MinCosmicMicrowaveBackground))]
    [DisplayName("Max Cosmic Microwave Background")]
    [Tooltip("The maximum value for the cosmic microwave background, in Kelvin.")]
    public float MaxCosmicMicrowaveBackground { get; init; }

    [Range(0, 100)]
    [LessThanOrEqualToProperty(nameof(MaxConnectivityFactor))]
    [DisplayName("Min Connectivity Factor")]
    [Tooltip("The minimum amount that the universes curves or folds to connect distant locations. Affect amount of wormholes. (0 = none, 100 = max)")]
    public float MinConnectivityFactor { get; init; }

    [Range(0, 100)]
    [LessThanOrEqualToProperty(nameof(MaxCosmicMicrowaveBackground))]
    [DisplayName("Min Cosmic Microwave Background")]
    [Tooltip("The minimum value for the cosmic microwave background, in Kelvin.")]
    public float MinCosmicMicrowaveBackground { get; init; }

    [Required]
    [DisplayName("Random Generator")]
    [Tooltip("The random generation algorithm to use.")]
    public IRandomGenerationAlgorithm RandomGenerator { get; init; }

    public UniverseSettings()
    {
        GaussianSigma = Constants.Advanced.Objects.Universe.GaussianSigma;
        GaussianKernelSize = Constants.Advanced.Objects.Universe.GaussianKernelSize;
        MinConnectivityFactor = Constants.Advanced.Objects.Universe.MinConnectivityFactor;
        MaxConnectivityFactor = Constants.Advanced.Objects.Universe.MaxConnectivityFactor;
        CurvatureFlatPercentage = Constants.Advanced.Objects.Universe.CurvatureFlatPercentage;
        CurvatureSphericalPercentage = Constants.Advanced.Objects.Universe.CurvatureSphericalPercentage;
        CurvatureHyperbolicPercentage = Constants.Advanced.Objects.Universe.CurvatureHyperbolicPercentage;
        RandomGenerator = Constants.Advanced.Objects.Universe.RandomGenerator;
        CosmicMicrowaveBackgroundThreshold = Constants.Advanced.Objects.Universe.CosmicMicrowaveBackgroundThreshold;
        InflationStart = Constants.Advanced.Objects.Universe.InflationStart;
        InflationEnd = Constants.Advanced.Objects.Universe.InflationEnd;
        MinCosmicMicrowaveBackground = Constants.Advanced.Objects.Universe.MinCosmicMicrowaveBackground;
        MaxCosmicMicrowaveBackground = Constants.Advanced.Objects.Universe.MaxCosmicMicrowaveBackground;
    }
}