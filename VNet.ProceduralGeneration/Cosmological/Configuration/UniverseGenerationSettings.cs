using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class UniverseGenerationSettings : ISettings
    {
        [Range(0, float.MaxValue)]
        [DisplayName("Gaussian Sigma")]
        [Tooltip("The amount of gaussian blur to apply to the Heightmap Image File (0 = none).")]
        public float GaussianSigma { get; init; }

        [Range(0, 100)]
        [LessThanOrEqualToProperty(nameof(MaxConnectivityFactor))]
        [DisplayName("Min Connectivity Factor")]
        [Tooltip("The minimum amount that the universes curves or folds to connect distant locations. Affect amount of wormholes. (0 = none, 100 = max)")]
        public float MinConnectivityFactor { get; init; }

        [Range(0, 100)]
        [GreaterThanOrEqualToProperty(nameof(MinConnectivityFactor))]
        [DisplayName("Max Connectivity Factor")]
        [Tooltip("The maximum amount that the universes curves or folds to connect distant locations. Affect amount of wormholes. (0 = none, 100 = max)")]
        public float MaxConnectivityFactor { get; init; }

        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(CurvatureSphericalPercentage), nameof(CurvatureHyperbolicPercentage) })]
        [DisplayName("Curvature Flat Percentage")]
        [Tooltip("Probability of the curvature of the universe being flat, as a percentage.")]
        public float CurvatureFlatPercentage { get; init; }

        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(CurvatureFlatPercentage), nameof(CurvatureHyperbolicPercentage) })]
        [DisplayName("Curvature Spherical Percentage")]
        [Tooltip("Probability of the curvature of the universe being spherical, as a percentage.")]
        public float CurvatureSphericalPercentage { get; init; }

        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(CurvatureFlatPercentage), nameof(CurvatureSphericalPercentage) })]
        [DisplayName("Curvature Hyperbolic Percentage")]
        [Tooltip("Probability of the curvature of the universe being hyperbolic, as a percentage.")]
        public float CurvatureHyperbolicPercentage { get; init; }

        [Required]
        [DisplayName("Random Generator")]
        [Tooltip("The random generation algorithm to use.")]
        public IRandomGenerationAlgorithm RandomGenerator { get; init; }

        [Range(0, float.MaxValue)]
        [DisplayName("Cosmic Microwave Background Threshold")]
        [Tooltip("The threshold for the cosmic microwave background.")]
        public float CosmicMicrowaveBackgroundThreshold { get; init; }

        [Range(0, float.MaxValue)]
        [LessThanOrEqualToProperty(nameof(InflationEnd))]
        [DisplayName("Inflation Start")]
        [Tooltip("The start of the inflation stage of the universe.")]
        public float InflationStart { get; init; }

        [Range(0, float.MaxValue)]
        [GreaterThanOrEqualToProperty(nameof(InflationStart))]
        [DisplayName("Inflation End")]
        [Tooltip("The end of the inflation stage of the universe. Value = 0 means no inflation.")]
        public float InflationEnd { get; init; }




        public UniverseGenerationSettings()
        {
            this.GaussianSigma = ConfigConstants.Universe.GaussianSigma;
            this.MinConnectivityFactor = ConfigConstants.Universe.MinConnectivityFactor;
            this.MaxConnectivityFactor = ConfigConstants.Universe.MaxConnectivityFactor;
            this.CurvatureFlatPercentage = ConfigConstants.Universe.CurvatureFlatPercentage;
            this.CurvatureSphericalPercentage = ConfigConstants.Universe.CurvatureSphericalPercentage;
            this.CurvatureHyperbolicPercentage = ConfigConstants.Universe.CurvatureHyperbolicPercentage;
            this.RandomGenerator = ConfigConstants.Universe.RandomGenerator;
            this.CosmicMicrowaveBackgroundThreshold = ConfigConstants.Universe.CosmicMicrowaveBackgroundThreshold;
            this.InflationStart = ConfigConstants.Universe.InflationStart;
            this.InflationEnd = ConfigConstants.Universe.InflationEnd;
        }
    }
}