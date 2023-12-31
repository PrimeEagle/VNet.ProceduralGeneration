using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Configuration.Attributes.Validation;
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

public class UniverseSettings
{
    [Range(0f, 1f)]
    [DisplayName("")]
    [Tooltip("")]
    public VNet.Configuration.Range<float> ConnectivityFactorRange { get; init; }

    [Range(0f, 100f)]
    [PercentageWithProperties(new string[] { nameof(CurvatureSphericalPercentage), nameof(CurvatureHyperbolicPercentage) })]
    [DisplayName("")]
    [Tooltip("")]
    public float CurvatureFlatPercentage { get; init; }

    [Range(0f, 100f)]
    [PercentageWithProperties(new string[] { nameof(CurvatureFlatPercentage), nameof(CurvatureSphericalPercentage) })]
    [DisplayName("")]
    [Tooltip("")]
    public float CurvatureHyperbolicPercentage { get; init; }

    [Range(0f, 100f)]
    [PercentageWithProperties(new string[] { nameof(CurvatureFlatPercentage), nameof(CurvatureHyperbolicPercentage) })]
    [DisplayName("")]
    [Tooltip("")]
    public float CurvatureSphericalPercentage { get; init; }

    [Required]
    [RangeLimitedTo<double>(0, float.MaxValue)]
    [DisplayName("Inflation Range")]
    [Tooltip("The range of inflation for the universe.")]
    public Range<float> InflationRange { get; init; }

    [Range(0, 5)]
    [DisplayName("Parallelism Level")]
    [Tooltip("The level of parallelism used during generation. Higher numbers mean more parallel processes. Value = 0 means no parallelism.")]
    public int ParallelismLevel { get; init; }

    [Required]
    [DisplayName("Random Generation Algorithm")]
    [Tooltip("The algorithm used during object generation to generate random values.")]
    public IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; init; }

    public UniverseSettings()
    {
        InflationRange = Constants.Advanced.Objects.Universe.InflationRange;
        RandomGenerationAlgorithm = Constants.Advanced.Objects.Universe.RandomGenerationAlgorithm;
        ConnectivityFactorRange = Constants.Advanced.Objects.Universe.ConnectivityFactorRange;
        CurvatureFlatPercentage = Constants.Advanced.Objects.Universe.CurvatureFlatPercentage;
        CurvatureSphericalPercentage = Constants.Advanced.Objects.Universe.CurvatureSphericalPercentage;
        CurvatureHyperbolicPercentage = Constants.Advanced.Objects.Universe.CurvatureHyperbolicPercentage;
        ParallelismLevel = Constants.Advanced.Objects.Universe.ParallelismLevel;
    }
}